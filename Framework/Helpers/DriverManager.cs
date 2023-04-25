using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace AppiumAutomationForDesktopAndMobile.Framewrok.Helpers
{
    public class DriverManager
    {
        public OpenQA.Selenium.Appium.Windows.WindowsDriver<WindowsElement> Driver_Desktop;
        public AppiumDriver<AndroidElement> Driver_Mobile;
        public IConfigurationRoot Configuration { get; set; }

        private string driverType;
        public DriverManager() { }

        public void LaunchApp(string appType)
        {
            driverType = appType;
            if (appType.ToLower().Equals("desktop"))
            {
                var appiumLocalService = new AppiumServiceBuilder().UsingPort(4723).Build();
                appiumLocalService.Start();
                AppiumOptions options = new AppiumOptions();
                options.AddAdditionalCapability("app", Configuration["Desktop:App"]);
                options.AddAdditionalCapability("autoAcceptAlerts", true);
                Driver_Desktop = new WindowsDriver<WindowsElement>(appiumLocalService, options);
            }
            else if (appType.ToLower().Equals("mobile_web"))
            {
                //var appiumLocalService = new AppiumServiceBuilder().UsingPort(4723).Build();
                //appiumLocalService.Start();
                AppiumOptions options = new AppiumOptions();
                Uri remoteUri = new Uri("http://127.0.0.1:4723/wd/hub");
                options.AddAdditionalCapability("deviceName", "emulator-5554");
                options.AddAdditionalCapability("automationName", "UiAutomator2");
                //options.AddAdditionalCapability("appPackage", Runner.config.AppUrl);
                options.AddAdditionalCapability("chromedriverExecutable", new FileInfo("Framework\\Helpers\\Driver\\chromedriver.exe").FullName);
                options.AddAdditionalCapability(CapabilityType.BrowserName, "Chrome");
                //options.AddAdditionalCapability("appActivity", "com.android.deskclock.DeskClock");
                /*com.google.android.apps.chrome.Main*/
                options.AddAdditionalCapability("platformName", "Android");
                options.SetLoggingPreference(LogType.Driver, LogLevel.Debug);
                //options.AddAdditionalCapability("version", "7.0");
                // options.AddAdditionalCapability("autoWebview", false);
                //options.AddAdditionalCapability("appWaitActivity", "com.google.android.apps.chrome.app.watchwhile.WatchWhileActivity");
                //Driver_Mobile = new AndroidDriver<AndroidElement>(remoteUri, options);
                AndroidDriver<AndroidElement> driver = new(remoteUri, options);
                //driver.Navigate().GoToUrl("https://www.bbc.co.uk");     

            }
            else if (appType.ToLower().Equals("mobile_native"))
            {
                AppiumOptions options = new AppiumOptions();
                Uri remoteUri = new Uri("http://127.0.0.1:4723/wd/hub");
                options.AddAdditionalCapability("deviceName", "emulator-5554");
                options.AddAdditionalCapability("appPackage", Configuration["Mobile_Native:App"]);
                options.AddAdditionalCapability("appActivity", "com.android.deskclock.DeskClock");
                options.AddAdditionalCapability("platformName", "Android");
                options.AddAdditionalCapability("autoWebview", false);
                Driver_Mobile = new AndroidDriver<AndroidElement>(remoteUri, options);
            }
        }

        public void TimeOut(TimeSpan timeout)
        {

            if (driverType.Equals("mobile_native"))
            {
                Driver_Mobile.Manage().Timeouts().ImplicitWait = timeout;
            }

            else if (driverType.Equals("desktop"))
            {
                Driver_Desktop.Manage().Timeouts().ImplicitWait = timeout;
            }
        }

        public void TapByCoordinates(int x, int y)
        {
            new TouchAction(Driver_Mobile)
                .Tap(x, y)
                .Wait(ms: 250).Perform();
        }


        public void TakeScreenshot(string name)
        {
            if (driverType.Equals("mobile_native"))
            {
                var screenshot = Driver_Mobile.GetScreenshot();
                var filePathToSave = $"C:\\TempPath\\AppiumMobileScreenshot\\{name}.png";
                screenshot.SaveAsFile(filePathToSave, ScreenshotImageFormat.Png);
            }

            else if (driverType.Equals("desktop"))
            {
                var screenshot = Driver_Desktop.GetScreenshot();
                var filePathToSave = $"C:\\TempPath\\AppiumDesktopScreenshot\\{name}.png";
                screenshot.SaveAsFile(filePathToSave, ScreenshotImageFormat.Png);
            }

        }

        public WebDriverWait GetWebDriverWaitMobile()
        {
            return new WebDriverWait(Driver_Mobile, TimeSpan.FromSeconds(30));
        }

        public WebDriverWait GetWebDriverWaitDesktop()
        {
            return new WebDriverWait(Driver_Desktop, TimeSpan.FromSeconds(30));

        }
        public void MobileWaitUntil(Func<IWebDriver, bool> function)
        {
            GetWebDriverWaitMobile().Until(function);
        }

        public void DesktopWaitUntil(Func<IWebDriver, bool> function)
        {
            GetWebDriverWaitDesktop().Until(function);
        }
        public void Quit()
        {
            if (driverType.Equals("mobile_native"))
            {
                if (Driver_Mobile != null)
                {
                    Driver_Mobile.Quit();
                }
                else throw new Exception("There was an error while trying to close the driver");

            }

            else if (driverType.Equals("desktop"))
            {
                if (Driver_Desktop != null)
                {
                    Driver_Desktop.Quit();
                }
                else throw new Exception("There was an error while trying to close the driver");

            }
        }
    }
}
