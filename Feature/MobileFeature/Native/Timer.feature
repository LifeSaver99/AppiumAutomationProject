Feature: Timer

@driver:mobile_native
Scenario: Start a new Timer
	Given I launch the Native clock app
	When  I click on the Timer tab
	And   I select "5" as the timer 
	And I click on the start timer button
	Then The start timer button should not exist

@driver:mobile_native
Scenario: Stop the Alarm Timer when trigeered
	Given I launch the Native clock app
	When  I click on the Timer tab
	And   I select "5" as the timer 
	And I click on the start timer button
	Then I click the stop button

@driver:mobile_native
Scenario: Start a new Timer without inputting the time value
	Given I launch the Native clock app
	When  I click on the Timer tab
	And I click on the start timer button
	Then The start timer button should not exist