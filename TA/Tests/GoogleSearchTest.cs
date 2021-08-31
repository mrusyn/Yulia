using NUnit.Framework;


namespace TA.Tests
{
    public class GoogleSearchTest : BaseTest
    {
       [Test]
       public void FindSiteUrlTest()
        {

            Pages.Start.Search("SoftServe");
            Assert.IsTrue(Pages.SearchResult.IsSearchSiteUrlEnabled());
        }

        public void ResultStats()
        {

            Pages.Start.Search("request");
            Assert.IsTrue(Pages.SearchResult.IsResultStatsDisplayed());
        }
    }
}
