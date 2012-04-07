using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BDDTest.PageObjects
{
    public abstract class Page
    {
        protected IWebDriver browser;

        protected Page(IWebDriver browser)
        {
            this.browser = browser;
        }

        protected void WaitFor(By locator, TimeSpan timeToWait)
        {
            IWait<IWebDriver> wait = new WebDriverWait(this.browser, timeToWait);

            wait.Until(x => x.FindElement(locator));
        }

        protected void Type(By by, string value)
        {
            browser.FindElement(by);
        }

        protected void Do(Action<IWebElement> thisAction, By on, bool throwIfNotFound)
        {
            var element = browser.FindElement(on);

            if (element == null && throwIfNotFound)
                throw new NoSuchElementException(string.Format("Unable to find {0}", on));

            thisAction.Invoke(element);
        }
    }
}
