using NUnit.Framework;
using SeleniumTestFramework.Pages;

namespace SeleniumTestFramework.Tests
{
    [TestFixture]
    public class MainPageTests : BaseTest
    {
        [Test]
        public void MainPage_SearchDress_ShouldDisplaySearchResult()
        {
            var mainPage = new MainPage(Driver);
            var searchResultPage = mainPage.Search("DRES");
            bool searchSummaryTextFieldIsDisplayed = searchResultPage.searchSummaryTextFieldIsDisplayed();

            Assert.IsTrue(searchSummaryTextFieldIsDisplayed);

        }
    }
}
