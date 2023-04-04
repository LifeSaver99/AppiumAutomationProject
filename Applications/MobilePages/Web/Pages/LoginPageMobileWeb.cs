using AppiumAutomationForDesktopAndMobile.Framewrok.Elements.MobileElement;
using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumAutomationForDesktopAndMobile.Applications.MobilePages.Web.Pages
{
    public class LoginPageMobileWeb
    {
        DriverManager _driverManager;
        public LoginPageMobileWeb(DriverManager driverManager)
        {
            _driverManager = driverManager;
        }

        public BaseElement AcceptButton => new BaseElement(_driverManager, "terms_accept");
        public BaseElement NoSyncButton => new BaseElement(_driverManager, "negative_button");
        public BaseElement ContinueAsUserButton => new BaseElement(_driverManager, "signin_fre_continue_button");
        public BaseElement UrlBar => new BaseElement(_driverManager, "url_bar");
        public BaseElement TrelloLoginSelect => new BaseElement(_driverManager, "49eaad9d-0f8c-4a19-867e-a3f47f01b5b5");


        public BaseElement UsernameNameInput => new BaseElement(_driverManager, "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[1]/android.widget.FrameLayout[2]/android.webkit.WebView/android.view.View/android.view.View/android.view.View[1]/android.widget.EditText");
        public BaseElement AcceptButtonAmazon => new BaseElement(_driverManager, "sp-cc-accept");
        public BaseElement UsernameLoginButton => new BaseElement(_driverManager, "login");
        public BaseElement PasswordLoginButton => new BaseElement(_driverManager, "//button[@id='login-submit']");
        public BaseElement PasswordInput => new BaseElement(_driverManager, "//input[@id='password']");
        public BaseElement BoardsTxt => new BaseElement(_driverManager, "//span[contains(text(),'Boards')]");
    }
}
