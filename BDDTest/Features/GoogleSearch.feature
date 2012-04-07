Feature: Search
	As general web user
	I want to search the internet
	So I can find what I'm looking for

@search
Scenario: Simple search
	Given I am on the search page
	When I search for Chocolate
	Then I am shown a list of results related to chocolate
