using System;
using TA.SeleniumUtils.Wrappers;
using OpenQA.Selenium;


namespace TA.SeleniumUtils
{
    public class LocalDriverBilder
    {
        private readonly WebDriverFactory factory;

        public LocalDriverBilder() : this(new WebDriverFactory())
        {

        }

        internal LocalDriverBilder(WebDriverFactory factory)
        {
            this.factory = factory;
        }

        public virtual IWebDriver Launch(string startingUrl)
        {
            var driver = CreateWebDriver();
            driver.Navigate().GoToUrl(startingUrl);
            return driver;
        }

        private IWebDriver CreateWebDriver()
        {
            return factory.CreateLocalChromeDriver();
        }
    }
}
