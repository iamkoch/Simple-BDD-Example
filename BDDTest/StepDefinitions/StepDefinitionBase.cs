using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BDDTest.StepDefinitions
{
    public class StepDefinitionBase
    {
        public StepDefinitionBase()
        {
            Browser = ScenarioContext.Current.Get<IWebDriver>("WebDriver");
            Uri = FeatureContext.Current.Get<string>("WebSiteUrl");
        }

        public IWebDriver Browser { get; private set; }

        public string Uri { get; private set; }
    }
}