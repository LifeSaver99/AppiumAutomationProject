using AppiumAutomationForDesktopAndMobile.Applications.MobilePages.Native.Pages;
using AppiumAutomationForDesktopAndMobile.Applications.MobilePages.Native.Section;
using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = AppiumAutomationForDesktopAndMobile.Applications.MobilePages.Native.Pages.Timer;

namespace AppiumAutomationForDesktopAndMobile.Applications.MobilePages.Native
{
    public class Clock
    {
        DriverManager _driverManager;
        public Clock(DriverManager driverManager)
        {
          _driverManager = driverManager;
        }

        public Stopwatch Stopwatch => new Stopwatch(_driverManager);
        public Commons Commons => new Commons(_driverManager);
        public Timer Timer => new Timer(_driverManager);


    }
}
