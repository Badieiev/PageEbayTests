Feature: EbayMenuTest

@mytag
Scenario: Clicking Getting Started option from the main menu should open Getting page
	Given I open official Ebay wibe site
	When I hover the "Electronics" menu item from the main menu
	And I click "Headphones"oprion from the main.menu
	Then Page with "Headphones" title should be opened