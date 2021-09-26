using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace TA.PageObjects
{
   public class MainPage :BasePage
    {

        public MainPage(IWebDriver driver) : base(driver)
        {

        }
        public MainPage()
        {

        }

        [FindsBy(How = How.XPath, Using = "//div[@class='QFw9Te']/descendant::textarea")]
        protected IWebElement OriginalTextInputField;


        [FindsBy(How = How.XPath, Using = "//span[@class='VIiyi']")]
        protected IWebElement TranslationField;

        [FindsBy(How = How.XPath, Using = "//*[@class='mqNsCe tQlvad']/descendant::span[@class='TYVfy']")]
        protected IWebElement HistoryLable;

        [FindsBy(How = How.XPath, Using = "//*[@id='ow23']/descendant::i")]
        protected IWebElement SwapLanguagesBtn;

        public void Search(string searchRequest)
        {
            var logger = new Logger();
            OriginalTextInputField?.Clear();
            OriginalTextInputField?.Click();
            OriginalTextInputField?.SendKeys(searchRequest);
            logger.Log("Search");
        }

        public string GetTtanslationText()
        {
            return TranslationField?.Text;
        }
        
        public HistoryPage GetHistoryPage()
        {
            HistoryLable?.Click();
            return new HistoryPage();
        }
        
        public void SwapLangueges()
        {
            SwapLanguagesBtn?.Click();
        }

        public bool Verification(int testpass)
        {
            if (testpass == 1)
            {
                return true;
            }
            else return false;
        }
    }
}
