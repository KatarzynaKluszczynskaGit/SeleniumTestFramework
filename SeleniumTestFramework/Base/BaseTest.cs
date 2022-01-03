using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumTestFramework.Utils;

namespace SeleniumTestFramework.Tests
{
    public class BaseTest
    {
        public IWebDriver Driver;
        private string baseUrl = "http://automationpractice.com/";

        [SetUp]
        public void SetUp()
        {
            var driverConfig = Configuration.Driver;
            Driver = GetWebDriver(driverConfig.BrowserName);
            Driver.Navigate().GoToUrl(baseUrl);
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Close();
            Driver.Quit();
        }

        private IWebDriver GetWebDriver(string browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                    return new ChromeDriver(Environment.CurrentDirectory);
                case "Firefox":
                    return new FirefoxDriver(Environment.CurrentDirectory);
                case "IE":
                    return new InternetExplorerDriver(Environment.CurrentDirectory);
                case "Edge":
                    return new EdgeDriver(Environment.CurrentDirectory);
                default:
                    return new ChromeDriver(Environment.CurrentDirectory);
            }
        }

    }
}
