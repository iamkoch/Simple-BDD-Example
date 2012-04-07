using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDTest.PageObjects;
using TechTalk.SpecFlow;

namespace BDDTest.StepDefinitions
{
    [Binding]
    public class SearchBoxStep : StepDefinitionBase
    {
        [When("I search for (.*)")]
        public void GivenIHaveEnteredSomethingIntoTheSearchBox(string searchTerm)
        {
            var searchPage = new SearchPage(Browser);
            
            searchPage
                .WithSearchString(searchTerm)
                .DoSearch();
        }
    }
}
