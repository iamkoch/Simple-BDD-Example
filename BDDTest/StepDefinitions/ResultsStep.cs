using BDDTest.PageObjects;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace BDDTest.StepDefinitions
{
    [Binding]
    public class ResultsStep : StepDefinitionBase
    {
        [Then("I am shown a list of results related to (.*)")]
        public void IAmShownAListOfResultsRelatedTo(string expectedResult)
        {
            var resultsPage = new ResultsPage(Browser);

            resultsPage
                .FirstCite()
                .Text
                .ToLowerInvariant()
                .Should()
                .Contain(expectedResult.ToLowerInvariant());
        }
    }
}
