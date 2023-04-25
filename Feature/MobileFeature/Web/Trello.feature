Feature: Trello

@driver:mobile_web
Scenario: Launch mobile emulator
	Given I launch the mobile app google chrome
	When I Navigate to the trello login page
	Then the login to trello text is displayed
