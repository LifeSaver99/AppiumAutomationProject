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
    public class FocusedDashboard
    {
        Clock _clock;
        DriverManager _driverManager;

        public FocusedDashboard(DriverManager driverManager,Clock clock)
        {
            _driverManager = driverManager;
            _clock = clock;
        }

        [When(@"I click the start session button")]
        public void WhenIClickTheStartSessionButton()
        {
            _clock.FocusDashboard.StartFocusButton.Click();

        }

        [Then(@"the pause button is displayed")]
        public void ThenThePauseButtonIsDisplayed()
        {
            _clock.FocusDashboard.PauseFocusButton.Click();
        }


        [Then(@"the pause button is be displayed")]
        public void ThenThePauseButtonIsBeDisplayed()
        {
            _clock.FocusDashboard.PauseFocusButton.WaitUntilVisible();
        }


        [Then(@"the get ready to focus header is displayed")]
        public void ThenTheGetReadyToFocusHeaderIsDisplayed()
        {
            _clock.FocusDashboard.StartFocusButton.WaitUntilVisible();
        }

    }
}
