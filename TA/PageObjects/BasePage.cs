using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace TA.PageObjects
{
    class BasePage
    {
        IWebDriver driver;
        WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        }

        [FindsBy(How = How.XPath, Using = "//input[@name='q']")]
        protected IWebElement SearchField;

        public void EnterSearchText(string searchRequest)
        {
            wait.Until(x => SearchField).SendKeys(searchRequest);
            SearchField.SendKeys(Keys.Return);
        }
    }
}
