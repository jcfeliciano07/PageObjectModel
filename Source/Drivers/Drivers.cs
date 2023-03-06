using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace PageObjectModel.Source.Drivers
{
    public class Drivers
    {
        public IWebDriver _driver;
        [SetUp]
        public void InitScript()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();

        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}

