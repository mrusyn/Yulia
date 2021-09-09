using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace TA.PageObjects
{
    public class HistoryPage : BasePage
    {

        public HistoryPage(IWebDriver driver) :base (driver)
        {
            
        }
        public HistoryPage() 
        {

        }

        [FindsBy(How = How.XPath, Using = "//*[@class='DLAnyc']/child::button")]
        protected IWebElement CleanHistoryBtn;

        public bool IsCleanHistoryButtonEnabled()
        {
            bool cleanHistoryBtn = CleanHistoryBtn.Enabled;
            return cleanHistoryBtn;
        }

        public void CleanHistory()
        {
            CleanHistoryBtn?.Click();
        }
    }
}
