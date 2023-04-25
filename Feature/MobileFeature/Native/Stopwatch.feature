Feature: Stopwatch

@driver:mobile_native
Scenario: Start a new Stopwatch
	Given I launch the Native clock app
	When  I click on the stopwatch tab
	And   I click the start Stopwatch button
	Then  The Stopwatch pause button is displayed

@driver:mobile_native
Scenario: Restart a paused stopwatch
	Given I launch the Native clock app
	When  I click on the stopwatch tab
	And   I click the start Stopwatch button
	And   I click the pause button
	And   I click the restart button
	Then  The restart button should not exist
