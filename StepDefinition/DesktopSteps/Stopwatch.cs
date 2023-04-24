using AppiumAutomationForDesktopAndMobile.Applications.DesktopPages;
using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;
using TechTalk.SpecFlow;

namespace AppiumAutomationForDesktopAndMobile.StepDefinition.DesktopSteps
{
    [Binding]
    public class Stopwatch
    {
        Clock _clock;
        DriverManager _driverManager;

        public Stopwatch(DriverManager driverManager, Clock clock)
        {
            _driverManager = driverManager;
            _clock = clock;
        }

        [Given(@"I launch the windows clock app")]
        public void GivenIAmOnTheWindowsApp()
        {
            _clock.SideMenu.FocusedSession.WaitUntilExist(5);
        }

        [When(@"I click on the Focus Session tab")]
        public void WhenIClickOnTheFocusSessionTab()
        {
            _clock.SideMenu.FocusedSession.Click();

        }

        [When(@"I click on the Stopwatch tab")]
        public void WhenIClickOnTheAlarmTab()
        {
            _clock.SideMenu.Stopwatch.Click();
        }

        [When(@"I click the start stopwatch button")]
        public void WhenIClickTheStartStopWatchButton()
        {
            _clock.Stopwatch.StartStopwatchButton.Click();

        }

        [Then(@"The stopwatch pause button is displayed")]
        public void ThenTheStopwatchPauseButtonIsDisplayed()
        {
            _clock.Stopwatch.PauseStopwatchButton.WaitUntilExist(10);
        }



    }
}
