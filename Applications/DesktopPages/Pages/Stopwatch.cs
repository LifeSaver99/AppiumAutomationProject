using AppiumAutomationForDesktopAndMobile.Framewrok.Elements.DesktopElement;
using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;

namespace AppiumAutomationForDesktopAndMobile.Applications.DesktopPages.Pages
{
    public class Stopwatch
    {
        DriverManager _driverManager;
        public Stopwatch(DriverManager driverManager)
        {
            _driverManager = driverManager;
        }
        public BaseElement GetReadyToFocusHeader => new BaseElement(_driverManager, "	/Window/Window[2]/Custom/Pane/Pane/Group[1]/Text[1]");
        public BaseElement StartStopwatchButton => new BaseElement(_driverManager, "Start");
        public BaseElement PauseStopwatchButton => new BaseElement(_driverManager, "Pause");
    }
}
