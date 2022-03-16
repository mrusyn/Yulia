using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TA.PageObjects
{
    public class BasePage 
    {
        private IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            driver = _driver;
        }
        public BasePage()
        {

        }
         
     

    }
}
