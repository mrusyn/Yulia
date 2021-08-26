using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TA
{
    
    public abstract class BaseTest
    {
        protected IWebDriver _driver;

        protected BaseTest()
        {
        }

       [OneTimeSetUp]
       protected void DoBeforeAllTest()
        {
            _driver = new ChromeDriver();
        }

        [TearDown]

        protected void CloseWindow()
        {
            _driver.Quit();
        }

        [SetUp]
       protected void DoBeforeEachTest()
        {
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Navigate().GoToUrl("https://google.com");
            _driver.Manage().Window.Maximize();
        }

       

    }
}
