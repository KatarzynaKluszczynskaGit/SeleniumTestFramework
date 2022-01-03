using OpenQA.Selenium;

namespace SeleniumTestFramework.Pages
{
    public class MainPage
    {
        private readonly IWebDriver _driver;

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement SearchField => _driver.FindElement(By.Id("search_query_top"));
        private IWebElement SerachConfirmBtn => _driver.FindElement(By.Name("submit_search"));
        private IWebElement Logo => _driver.FindElement(By.Id("header_logo"));
        private IWebElement ContactLink => _driver.FindElement(By.Id("contact-link"));
        private IWebElement UserInfo => _driver.FindElement(By.Id("header_user_info"));

        public SearchResultPage Search(string serachQuery)
        {
            SearchField.SendKeys(serachQuery);
            SerachConfirmBtn.Click();

            return new SearchResultPage(_driver);
        }
    }
}
