Feature: Expedia Feature
	In order to test search traveeling functionality,
	User is searching flight and accomodationfor one adult and one child.
	User should get valid search result


Scenario: Search Flight and Accomodation, Verify the result
	Given I navigate to the Expedia website
	When I look for a flight+accommodation from Brussels to New York
	Then the result page contains travel option for the chosen destination