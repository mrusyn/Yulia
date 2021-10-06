using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;


namespace TA.Tests
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("CalculatorTests")]
    [AllureDisplayIgnored]
    public class HistoryTests : BaseTest
    {
        [Test(Description = "Add two integers and returns the sum")]
        [AllureTag("CI")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("8911")]
        [AllureTms("532")]
        [AllureOwner("Anton")]
        [AllureSubSuite("Add")]
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