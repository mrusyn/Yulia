using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace TA.PageObjects
{
    public class BasePage 
    {
        IWebDriver driver;
        WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        }
        public BasePage()
        {

        }

        
    }
}
