using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModel.Source.Drivers;
using PageObjectModel.Source.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace PageObjectModel.Test
{
    //[Parallelizable(ParallelScope.All)] -->Run test cases in parallel
    public class HomeTest : Drivers
    {

        [Test]
        public void SearchBook()
        {
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("https://amazon.com");
            _driver.Manage().Window.Maximize();
            hp.SearchMethod("webdriver book");
            Assert.True(_driver.Title.Contains("webdriver book"));

        }

        [Test]
        public void SearchPhone()
        {
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("https://amazon.com");
            _driver.Manage().Window.Maximize();
            hp.SearchMethod("iphone 13");
            Assert.True(_driver.Title.Contains("iphone 13"));

        }

        [Test]
        public void SearchWatch()
        {
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("https://amazon.com");
            _driver.Manage().Window.Maximize();
            hp.SearchMethod("apple watch");
            Assert.True(_driver.Title.Contains("apple watch"));

        }
    }
}
  


