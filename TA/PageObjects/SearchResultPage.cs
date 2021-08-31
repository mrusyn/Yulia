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

        [FindsBy(How = How.XPath, Using = "//*[@id='result-stats']")]
        protected IWebElement ResultStats;

        [FindsBy(How = How.XPath, Using = "//*[@class='gLFyf gsfi']")]
        protected IWebElement SearchResultPageSearchField;

        public bool IsSearchSiteUrlEnabled()
        {
            bool searhedSiteUrl = SearhedSiteUrl.Enabled;
            return searhedSiteUrl;
        }

        public bool IsResultStatsDisplayed()
        {
            bool resultStats = ResultStats.Displayed;
            return resultStats;
        }

        public bool IsSearchResultPageSearchFieldEnabled()
        {
            bool searchResultPageSearchField = SearchResultPageSearchField.Enabled;
            return searchResultPageSearchField;
        }
    }
}
