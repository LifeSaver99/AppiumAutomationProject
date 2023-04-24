using AppiumAutomationForDesktopAndMobile.Framewrok.Elements.DesktopElement;
using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;

namespace AppiumAutomationForDesktopAndMobile.Applications.DesktopPages.Pages
{
    public class FocusedDashboard
    {
        DriverManager _driverManager;
        public FocusedDashboard(DriverManager driverManager)
        {
            _driverManager = driverManager;
        }
        public BaseElement GetReadyToFocusHeader => new BaseElement(_driverManager, "	/Window/Window[2]/Custom/Pane/Pane/Group[1]/Text[1]");
        public BaseElement StartFocusButton => new BaseElement(_driverManager, "Resume focus session");
        public BaseElement PauseFocusButton => new BaseElement(_driverManager, "Pause focus session");
    }
}

