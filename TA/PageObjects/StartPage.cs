using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace TA.PageObjects
{
   public class StartPage :BasePage
    {

        public StartPage(IWebDriver driver) : base(driver)
        {

        }
        public StartPage()
        {

        }

        [FindsBy(How = How.XPath, Using = "//*[@id= 'input']")]
        protected IWebElement SearchField;

        public SearchResultPage Search(string searchRequest)
        {
            SearchField.SendKeys(searchRequest);
            SearchField.Submit();
            return new SearchResultPage();
        }
        
    }
}
