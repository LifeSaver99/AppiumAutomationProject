using AppiumAutomationForDesktopAndMobile.Applications.DesktopPages.Pages;
using AppiumAutomationForDesktopAndMobile.Applications.DesktopPages.Section;
using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumAutomationForDesktopAndMobile.Applications.DesktopPages
{
    public class Clock
    {
        DriverManager _driverManager;

        public Clock(DriverManager driverManager)
        {
            _driverManager = driverManager;
        }
        public FocusedDashboard FocusDashboard => new FocusedDashboard(_driverManager);
        public SideMenu SideMenu => new SideMenu(_driverManager);
        public Alarm Alarm => new Alarm(_driverManager);
        public Stopwatch Stopwatch => new Stopwatch(_driverManager);
        public Settings Settings => new Settings(_driverManager);
    }
}

