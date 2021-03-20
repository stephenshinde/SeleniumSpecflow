Feature: DuckDuckGo Feature
	In order to test search functionality with City Name-Bahamas, Amsterdam
	User should get valid search result


	Scenario: Validate Bahamas Search Result
	Given I navigate to the Duckduckgo website
	When I search for "Bahamas"
	Then I should navigate on "Bahamas" result page
	And I should get Bahamas keyword in all page link

	Scenario: Validate Amsterdam Search Result
	Given I navigate to the Duckduckgo website
	When I search for "Amsterdam"
	Then I should navigate on "Amsterdam" result page
	And I should get Amsterdam keyword in all page link

