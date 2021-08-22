using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TA.SeleniumUtils;

namespace TA
{
    
    public abstract class BaseTest
    {
        protected LocalDriverBilder builder;
        protected string startingUrl;
        protected string epochStartTime;
        protected CommonUtils commonUtils = new CommonUtils();

        protected BaseTest()
        {
            
            this.epochStartTime = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();
        }

        public IWebDriver InitializeDriver()
        {
            LocalDriverBilder builder = new LocalDriverBilder();
            this.startingUrl = "http://google.com";
            var driver = builder.Launch(startingUrl);
            return driver;
        }


    }
}
