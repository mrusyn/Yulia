using NUnit.Framework;


namespace TA.Tests
{
    public class SearchResultPageTest : BaseTest
    {
        [Test]
        public void SearchResultPageSearchField()
        {
            Pages.Start.Search("flowers");
            Assert.IsTrue(Pages.SearchResult.IsSearchResultPageSearchFieldEnabled());
        }
    }
}