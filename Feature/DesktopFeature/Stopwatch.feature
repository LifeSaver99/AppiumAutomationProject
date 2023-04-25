Feature: StopWatchfeature

@driver:desktop
Scenario: Start a new Stopwatch
	Given I launch the windows clock app
	When  I click on the Stopwatch tab
	And   I click the start stopwatch button
	Then  The stopwatch pause button is displayed