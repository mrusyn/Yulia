using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace TA.PageObjects
{
    public class SearchResultPage : BasePage
    {

        public SearchResultPage(IWebDriver driver) :base (driver)
        {
            
        }
        public SearchResultPage() 
        {

        }

        [FindsBy(How = How.XPath, Using = "//*[@class='g']/descendant::a[@href='https://www.softserveinc.com/uk-ua']")]
        protected IWebElement SearhedSiteUrl;




    }
}
