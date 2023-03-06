using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModel.Source.Drivers;
using PageObjectModel.Source.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace PageObjectModel.Test
{
    public class LoginTest: Drivers
    {
      
        [Test]
        public void InvalidLogin()
        {
            LoginPage lp = new LoginPage(_driver);
            _driver.Navigate().GoToUrl("https://amazon.com");
            lp.LoginMethod(user: "test@gmail.com", password: "pass");
            Assert.True(condition: _driver.Title.Contains(value: "Amazon Sign-In"));

        }
        }
    }



