using AppiumAutomationForDesktopAndMobile.Framewrok.Elements.DesktopElement;
using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumAutomationForDesktopAndMobile.Applications.DesktopPages.Pages
{
    public class Settings
    {
        DriverManager _driverManager;
        public Settings(DriverManager driverManager)
        {
            _driverManager = driverManager;
        }
        public BaseElement SettingsHeader => new BaseElement(_driverManager, "Settings");
        public BaseElement SignInButton => new BaseElement(_driverManager, "Sign in");

    }
}
