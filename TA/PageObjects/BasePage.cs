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

        [FindsBy(How = How.XPath, Using = "//input[@name='q']")]
        protected IWebElement SearchField;

        public SearchResultPage EnterSearchText(string searchRequest)
        {
            wait.Until(x => SearchField).SendKeys(searchRequest);
            SearchField.Submit();
            return new SearchResultPage(driver);
        }
    }
}
