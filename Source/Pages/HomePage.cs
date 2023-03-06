using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageObjectModel.Source.Pages
{
    public class HomePage
    {
        private IWebDriver _driver;
        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        private IWebElement _searchtxtbox;

        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        private IWebElement _searchbtn;

        [FindsBy(How = How.Id, Using = "nav-link-accountList")]
        public IWebElement _signinlink;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void SearchMethod(String searchtext)
        {
            _searchtxtbox.SendKeys(searchtext);
            _searchbtn.Click();
            //_signinlink.Click();
        }
            

    }
}
