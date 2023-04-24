using AppiumAutomationForDesktopAndMobile.Framewrok.Elements.MobileElement;
using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;

namespace AppiumAutomationForDesktopAndMobile.Applications.MobilePages.Native.Section
{
    public class Commons
    {
        DriverManager _driverManager;
        public Commons(DriverManager driverManager)
        {
            _driverManager = driverManager;
        }
        public BaseElement StopwatchTab => new BaseElement(_driverManager, @"//android.widget.ImageView[@content-desc=""Stopwatch""]");
        public BaseElement TimerTab => new BaseElement(_driverManager, @"//android.widget.ImageView[@content-desc=""Timer""]");
    }
}
