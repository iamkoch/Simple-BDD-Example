using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;

namespace BDDTest.EventDefinition
{
    [Binding]
    public class EventDefinition
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            var internetExplorerOptions = new InternetExplorerOptions
                                          {
                                              IntroduceInstabilityByIgnoringProtectedModeSettings = true
                                          };
            var driver = new InternetExplorerDriver(internetExplorerOptions);
            ScenarioContext.Current.Set(driver, "WebDriver");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var webDriver = ScenarioContext.Current.Get<IWebDriver>("WebDriver");
            webDriver.Close();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            var url = "http://www.google.com";
            FeatureContext.Current.Set(url, "WebSiteUrl");
        }
    }
}
