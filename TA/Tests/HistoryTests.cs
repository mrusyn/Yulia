using NUnit.Framework;


namespace TA.Tests
{
    public class HistoryTests : BaseTest
    {
        [Test]
        public void CleanHistory()
        {
            Pages.Main.Search("Clean");
            Pages.Main.GetHistoryPage();
            Pages.History.CleanHistory();
            //Assert.IsFalse(Pages.History.IsCleanHistoryButtonEnabled());
            Assert.IsTrue(Pages.Main.Verification(1), "Pass");
        }
    }
}