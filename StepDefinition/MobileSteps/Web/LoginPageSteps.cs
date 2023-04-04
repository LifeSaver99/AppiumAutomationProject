using AppiumAutomationForDesktopAndMobile.Applications.DesktopPages;
using AppiumAutomationForDesktopAndMobile.Applications.MobilePages.Web;
using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AppiumAutomationForDesktopAndMobile.StepDefinition.MobileSteps.Web
{
    [Binding]
    public class LoginPageSteps
    {
        Trello _trello;
        DriverManager _driverManager;

        public LoginPageSteps(DriverManager driverManager, Trello trello)
        {
            _driverManager = driverManager;
            _trello = trello;
        }

        public LoginPageSteps(DriverManager driverManager)
        {
        }

        [Given(@"I launch the mobile app google chrome")]
        public void GivenILaunchTheMobileAppGoogleChrome()
        {
            //_trello.AcceptButton.ClickID();
            _trello.LoginPageMobileWeb.ContinueAsUserButton.ClickID();
            //_trello.NoSyncButton.ClickID();

        }

        [When(@"I Navigate to the trello login page")]
        public void WhenINavigateToTheTrelloLoginPage()
        {
            _driverManager.Driver_Mobile.Navigate().GoToUrl("https://www.trello.com/login");
            Thread.Sleep(3000);

            //Console.WriteLine(((IContextAware)_driverManager.Driver_Mobile).Contexts);

            //var contexts = ((IContextAware)_driverManager.Driver_Mobile).Contexts;
            //string webviewContext = null;
            //for (int i = 0; i < contexts.Count; i++)
            //{
            //    Console.WriteLine(contexts[i]);
            //    if (contexts[i].Contains("WEBVIEW_1"))
            //    {
            //        webviewContext = contexts[i];
            //        break;
            //    }
            //}
        }


        //    _trello.UsernameNameInput.ClickID();
        //    _trello.UsernameNameInput.SendKeysID("dapsymigo001@gmail.com");
        //    Thread.Sleep(3000);
        //    _trello.UsernameLoginButton.ClickID();
        //    Thread.Sleep(3000);
        //    _trello.PasswordInput.SendKeysXPath("Oreoluwa1$");
        //    _trello.PasswordLoginButton.ClickXpath();
        //    _trello.BoardsTxt.WaitUntilExist(30);
        //}

        [Then(@"the login to trello text is displayed")]
        public void ThenTheLoginToTrelloTextIsDisplayed()
        {
            throw new PendingStepException();
        }

    }
}
