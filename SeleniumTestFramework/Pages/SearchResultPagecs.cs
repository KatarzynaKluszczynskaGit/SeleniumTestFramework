using OpenQA.Selenium;

namespace SeleniumTestFramework.Pages
{
    public class SearchResultPage
    {
        private readonly IWebDriver _driver;

        public SearchResultPage(IWebDriver driver)
        {
            _driver = driver;
        }

        IWebElement SearchSummaryTextField => _driver.FindElement(By.CssSelector("h1.product-listing span.lighter"));

        public bool searchSummaryTextFieldIsDisplayed()
        {
            try
            {
                return SearchSummaryTextField.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
