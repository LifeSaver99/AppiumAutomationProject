using AppiumAutomationForDesktopAndMobile.Applications.MobilePages.Native;
using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AppiumAutomationForDesktopAndMobile.StepDefinition.MobileSteps.Native
{
    [Binding]
    public class Timer
    {
        Clock _clock;
        DriverManager _driverManager;

        public Timer(DriverManager driverManager, Clock clock)
        {
            _driverManager = driverManager;
            _clock = clock;
        }



        [When(@"I click on the Timer tab")]
        public void WhenIClickOnTheTimerTab()
        {
            _clock.Commons.TimerTab.ClickXpath();
        }

        [When(@"I select ""([^""]*)"" as the timer")]
        public void WhenISelectAsTheTimer(string p0)
        {
           _clock.Timer.FiveButtonButton.ClickXpath();
        }

        [When(@"I click on the start timer button")]
        public void WhenIClickOnTheStartTimerButton()
        {
           _clock.Timer.TimerCreateButton.ClickXpath();
        }

        [Then(@"The start timer button should not exist")]
        public void ThenTheStartTimerButtonShouldNotExist()
        {
            _clock.Timer.TimerCreateButton.NotExists();
        }

        [Then(@"I click the stop button")]
        public void ThenIClickTheStopButton()
        {
            Thread.Sleep(6000);
            _clock.Timer.TapStopButton();
        }
         
    }
}
