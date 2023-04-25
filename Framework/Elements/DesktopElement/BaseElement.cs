using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;
using OpenQA.Selenium.Appium.Windows;

namespace AppiumAutomationForDesktopAndMobile.Framewrok.Elements.DesktopElement
{
    public class BaseElement
    {
        private DriverManager _driverManager;
        string _elementLocator;
        public BaseElement(DriverManager driverManager, string elementLocator)
        {
            _driverManager = driverManager;
            _elementLocator = elementLocator;
        }


        public WindowsElement GetElement()
        {
            return _driverManager.Driver_Desktop.FindElementByName(_elementLocator);
        }


        public bool Exists(TimeSpan timeout)
        {
            bool exists = true;
            try
            {
                GetElement();
            }

            catch
            {
                exists = false;
            }
            return exists;
        }

        public bool NotExists(TimeSpan timeout)
        {
            bool exists = false;
            try
            {
                GetElement();
            }

            catch
            {
                exists = true;
            }
            return exists;
        }

        public void AssertTextContains(string expected)
        {
            WaitUntilExist(30);
            string elementText = GetElement().Text;
            Assert.That(elementText.Contains(expected));
        }

        public void Click()
        {
            _driverManager.Driver_Desktop.FindElementByName(_elementLocator).Click();
        }

        public void SendKeys(string text)
        {
            _driverManager.Driver_Desktop.FindElementByName(_elementLocator).SendKeys(text);
        }

        public void WaitUntilExist(int timeInSeconds)
        {
            Exists(TimeSpan.FromSeconds(timeInSeconds));
        }

        public void WaitUntilVisible()
        {
            _driverManager.DesktopWaitUntil(_driverManager => GetElement().Displayed);
        }

        public void WaitUntilNotVisible(string appType)
        {
            _driverManager.DesktopWaitUntil(_driverManager => !GetElement().Displayed);
        }

    }
}
