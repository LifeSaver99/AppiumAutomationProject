using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumAutomationForDesktopAndMobile.Framewrok.Elements.MobileElement
{
    public class BaseElement
    {

        public DriverManager _driverManager;
        public string _elementLocator;
        public BaseElement(DriverManager driverManager, string elementLocator)
        {
            _driverManager = driverManager;
            _elementLocator = elementLocator;
        }


        public IWebElement GetElement()
        {
            return (AndroidElement)_driverManager.Driver_Mobile.FindElementByXPath(_elementLocator);
        }


        public bool Exists(TimeSpan timeout)
        {
            bool exists = true;
            try
            {
                GetElement();
            }

            catch
            {
                exists = false;
            }
            return exists;
        }

        public bool NotExists()
        {
            bool exists = false;
            try
            {
                GetElement();
            }

            catch
            {
                exists = true;
            }
            return exists;
        }

        public void AssertTextContains(string expected)
        {
            WaitUntilExist(30);
            string elementText = GetElement().Text;
            Assert.That(elementText.Contains(expected));
        }

        public string GetText()
        {
            
            return GetElement().Text;
            
        }

        public void ClickID()
        {
            _driverManager.Driver_Mobile.FindElementById(_elementLocator).Click();
        }

       
        public void ClickXpath()
        {
            _driverManager.Driver_Mobile.FindElementByXPath(_elementLocator).Click();

        }

        public void SendKeysID(string text)
        {
            _driverManager.Driver_Mobile.FindElementById(_elementLocator).SendKeys(text);
        }

        public void SendKeysXPath(string text)
        {
            _driverManager.Driver_Mobile.FindElementById(_elementLocator).SendKeys(text);
        }

        public void WaitUntilExist(int timeInSeconds)
        {
            Exists(TimeSpan.FromSeconds(timeInSeconds));
        }

        public void WaitUntilVisible()
        {
            _driverManager.DesktopWaitUntil(_driverManager => GetElement().Displayed);
        }

        public void WaitUntilNotVisible(string appType)
        {
            _driverManager.DesktopWaitUntil(_driverManager => !GetElement().Displayed);
        }
    }
}
