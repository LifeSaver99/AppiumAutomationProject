using AppiumAutomationForDesktopAndMobile.Framewrok.Elements.MobileElement;
using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;

namespace AppiumAutomationForDesktopAndMobile.Applications.MobilePages.Native.Pages
{
    public class Stopwatch
    {
        DriverManager _driverManager;
        public Stopwatch(DriverManager driverManager)
        {
            _driverManager = driverManager;
        }
        public BaseElement StopwatchButton => new BaseElement(_driverManager, @"//android.widget.ImageView[@content-desc=""Stopwatch""]");
        public BaseElement StopwatchStartButton => new BaseElement(_driverManager, @"//android.widget.ImageButton[@content-desc=""Start""]");
        public BaseElement StopwatchPauseButton => new BaseElement(_driverManager, @"//android.widget.ImageButton[@content-desc=""Pause""]");
        public BaseElement StopwatchRestartButton => new BaseElement(_driverManager, @"//android.widget.ImageButton[@content-desc=""Reset""]");

    }
}
