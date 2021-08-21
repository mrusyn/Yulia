using NUnit.Framework;
using OpenQA.Selenium;

namespace TA
{
    public class Tests
    {
        private IWebDriver webDriver;
        private readonly By _searchField = By.XPath("//input[@name='q']");
        private readonly By _siteUrl = By.XPath("//*[@class='g']/descendant::a[@href='https://www.softserveinc.com/uk-ua']");

        [SetUp]
        public void Setup()
        {
            webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();
            webDriver.Navigate().GoToUrl("https://www.google.com");
            webDriver.Manage().Window.Maximize();

        }

        [Test]
        public void Test1()
        {
            var searchField = webDriver.FindElement(_searchField);
            searchField.SendKeys("SoftServe");
            searchField.SendKeys(Keys.Enter);
            var siteUrl = webDriver.FindElement(_siteUrl);
            Assert.IsTrue(siteUrl.Enabled, "Site not found");
        }

        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }
    }
}