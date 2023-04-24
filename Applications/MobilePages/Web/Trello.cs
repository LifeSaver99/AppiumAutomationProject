using AppiumAutomationForDesktopAndMobile.Applications.MobilePages.Web.Pages;
using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;

namespace AppiumAutomationForDesktopAndMobile.Applications.MobilePages.Web
{
    public class Trello
    {
        DriverManager _driverManager;
        public Trello(DriverManager driverManager)
        {
            _driverManager = driverManager;
        }
        public LoginPageMobileWeb LoginPageMobileWeb => new(_driverManager);
    }
}

