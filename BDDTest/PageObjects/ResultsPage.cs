using System.Linq;
using OpenQA.Selenium;

namespace BDDTest.PageObjects
{
    public class ResultsPage : Page
    {
        private static class Locator
        {
            public static readonly By CitedUrl = By.TagName("cite");
        }

        public ResultsPage(IWebDriver browser) : base(browser)
        {
        }

        public IWebElement FirstCite()
        {
            var elements = browser.FindElements(Locator.CitedUrl);

            var firstCitedElement = elements.FirstOrDefault();

            if (firstCitedElement == null)
                throw new NoSuchElementException(Locator.CitedUrl.ToString());

            return firstCitedElement;
        }
    }
}
