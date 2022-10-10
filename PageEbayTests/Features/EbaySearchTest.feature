Feature: EbaySearchTest

A short summary of the feature

@tag1
Scenario: Find a product through the search field
	Given I open official Ebay site
	When I click click on the search field
	And I click button Search
	Then Page with product should be opened