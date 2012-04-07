using TechTalk.SpecFlow;

namespace BDDTest.StepDefinitions
{
    [Binding]
    public class SearchPageStep : StepDefinitionBase
    {
        [Given(@"I am on the search page")]
        public void GivenIAmOnTheSearchPage()
        {
            Browser
                .Navigate()
                .GoToUrl(Uri);
        }
    }
}