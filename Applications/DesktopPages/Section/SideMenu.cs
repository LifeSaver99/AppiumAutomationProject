﻿using AppiumAutomationForDesktopAndMobile.Framewrok.Elements.DesktopElement;
using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumAutomationForDesktopAndMobile.Applications.DesktopPages.Section
{
    public class SideMenu
    {
        DriverManager _driverManager;
        public SideMenu(DriverManager driverManager)
        {
            _driverManager = driverManager;
        }

        public BaseElement FocusedSession => new BaseElement(_driverManager, "Focus sessions");
        public BaseElement Alarm => new BaseElement(_driverManager, "Alarm");
        public BaseElement Stopwatch => new BaseElement(_driverManager, "Stopwatch");
        public BaseElement Settings => new BaseElement(_driverManager, "Settings");
    }

}
