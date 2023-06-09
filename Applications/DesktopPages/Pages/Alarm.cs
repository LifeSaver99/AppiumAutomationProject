﻿using AppiumAutomationForDesktopAndMobile.Framewrok.Elements.DesktopElement;
using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;

namespace AppiumAutomationForDesktopAndMobile.Applications.DesktopPages.Pages
{
    public class Alarm
    {

        DriverManager _driverManager;
        public Alarm(DriverManager driverManager)
        {
            _driverManager = driverManager;
        }

        public BaseElement StartNewAlarmButton => new BaseElement(_driverManager, "	/Window/Window[2]/Custom/Pane/AppBar/Button[2]");
        public BaseElement AlarmNameInput => new BaseElement(_driverManager, "TextBoxTextBox");

    }
}

