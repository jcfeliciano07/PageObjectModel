using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Source.Pages
{
    class LoginPage
    {
        IWebDriver _webdriver;

        [FindsBy(How = How.Id, Using = "ap_email")]
        private IWebElement _emailtxt;

        [FindsBy(How = How.XPath, Using = "//input[@id='continue']")]
        private IWebElement _continuebtn;

        [FindsBy(How = How.Id, Using = "ap_password")]
        private IWebElement _passwordtxt;

        [FindsBy(How = How.Id, Using = "signInSubmit")]
        private IWebElement _signinbtn;

        public LoginPage(IWebDriver webdriver)

        {
           _webdriver = webdriver;
            PageFactory.InitElements(_webdriver, this);
        }

        public void LoginMethod(String user, String password)
        {
            HomePage hp = new HomePage(driver: _webdriver);
            hp._signinlink.Click();
            _emailtxt.SendKeys(text : user);
            _continuebtn.Click();
            _passwordtxt.SendKeys(text: password);
            _signinbtn.Click();
        }

    }
}
