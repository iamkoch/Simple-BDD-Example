using System;
using OpenQA.Selenium;

namespace BDDTest.PageObjects
{
    public class SearchPage : Page
    {
        private static class Locator
        {
            public static readonly By SearchBox = By.Name("q");
            public static readonly By SubmitButtonResultsPage = By.Name("btnG");
        }

        public SearchPage(IWebDriver browser)
            : base(browser)
        {
            
        }

        public SearchPage WaitForDisplay()
        {
            WaitFor(Locator.SearchBox, TimeSpan.FromSeconds(2));
            return this;
        }

        public SearchPage WithSearchString(string searchTerm)
        {
            Do(x => x.SendKeys(searchTerm), Locator.SearchBox, true);

            return this;
        }

        public SearchPage DoSearch()
        {
            Do(x => x.Click(), Locator.SubmitButtonResultsPage, false);

            return this;
        }
    }
}