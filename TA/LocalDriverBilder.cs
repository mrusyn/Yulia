using System;
using TA.SeleniumUtils.Wrappers;
using OpenQA.Selenium;


namespace TA.SeleniumUtils
{
    public class LocalDriverBilder
    {
        private readonly WebDriverFactory factory;

        internal LocalDriverBilder(WebDriverFactory factory)
        {
            this.factory = factory;
        }

        public virtual IWebDriver Launch(string browserTarget, string startingUrl)
        {
            var driver = CreateWebDriver(browserTarget);
            driver.Navigate().GoToUrl(startingUrl);
            return driver;
        }

        private IWebDriver CreateWebDriver(string browserTarget)
        {
            switch (browserTarget)
            {
                case BrowserTarget.Chrome:
                    return factory.CreateLocalChromeDriver();
                default:
                    throw new NotSupportedException($"{browserTarget} is not supported local browser type");
            }
        }
    }
}
