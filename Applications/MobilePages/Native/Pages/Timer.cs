using AppiumAutomationForDesktopAndMobile.Framewrok.Elements.MobileElement;
using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumAutomationForDesktopAndMobile.Applications.MobilePages.Native.Pages
{
    public class Timer
    {
        DriverManager _driverManager;
        public Timer(DriverManager driverManager)
        {
            _driverManager = driverManager;
        }
        public BaseElement FiveButtonButton => new BaseElement(_driverManager, "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout[3]/android.widget.Button[2]");
        public BaseElement TimerCreateButton => new BaseElement(_driverManager, @"//android.widget.ImageButton[@content-desc=""Start""]");

        public void TapStopButton()
        {
            _driverManager.TapByCoordinates(70, 352);
        }
    }
}

