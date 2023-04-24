using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;
using TechTalk.SpecFlow;
using Clock = AppiumAutomationForDesktopAndMobile.Applications.MobilePages.Native.Clock;

namespace AppiumAutomationForDesktopAndMobile.StepDefinition.MobileSteps.Native
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

        [StepDefinition(@"I launch the Native clock app")]
        public void GivenILaunchTheNativeClockApp()
        {
            _clock.Stopwatch.StopwatchButton.WaitUntilExist(5);
        }

        [StepDefinition(@"I click on the stopwatch tab")]
        public void WhenIClickOnTheStopwatchTab()
        {
            _clock.Stopwatch.StopwatchButton.ClickXpath();
        }

        [StepDefinition(@"I click the start Stopwatch button")]
        public void WhenIClickTheStartStopwatchButton()
        {
            _clock.Stopwatch.StopwatchStartButton.ClickXpath();
        }

        [StepDefinition(@"The Stopwatch pause button is displayed")]
        public void ThenTheStopwatchPauseButtonIsDisplayed()
        {
            _clock.Stopwatch.StopwatchPauseButton.WaitUntilExist(10);
        }

        [StepDefinition(@"I click the pause button")]
        public void WhenIClickThePauseButton()
        {
            _clock.Stopwatch.StopwatchPauseButton.ClickXpath();
        }


        [StepDefinition(@"I click the restart button")]
        public void WhenIClickTheRestartButton()
        {
            _clock.Stopwatch.StopwatchRestartButton.ClickXpath();
        }

        [StepDefinition(@"The restart button should not exist")]
        public void ThenTheRestartButtonShouldNotExist()
        {
            _clock.Stopwatch.StopwatchRestartButton.WaitUntilExist(10);
        }


    }
}
