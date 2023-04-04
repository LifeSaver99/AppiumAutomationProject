using AppiumAutomationForDesktopAndMobile.Applications.DesktopPages;
using AppiumAutomationForDesktopAndMobile.Applications.MobilePages.Web;
using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AppiumAutomationForDesktopAndMobile.StepDefinition.DesktopSteps
{
    [Binding]
    public class Settings
    {
        Clock _clock;
        DriverManager _driverManager;

        public Settings(DriverManager driverManager, Clock clock)
        {
            _driverManager = driverManager;
            _clock = clock;
        }

        [When(@"I click on the Settings tab")]
        public void WhenIClickOnTheSettingsTab()
        {
            _clock.SideMenu.Settings.Click();
            _clock.Settings.SettingsHeader.WaitUntilExist(10);
        }

        [Then(@"The sign in button is displayed")]
        public void ThenTheSignInButtonIsDisplayed()
        {
            _clock.Settings.SignInButton.AssertTextContains("Sign in");
        }

    }
}
