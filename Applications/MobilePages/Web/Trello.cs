using AppiumAutomationForDesktopAndMobile.Framewrok.Elements.MobileElement;
using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;
using AppiumAutomationForDesktopAndMobile.Applications.MobilePages.Web.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

