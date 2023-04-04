Feature: FocusedDashboardFeature




Scenario: Navigate to the Focus Session Tab
	Given I launch the windows clock app
	When  I click on the Focus Session tab
	Then  the get ready to focus header is displayed

Scenario: Start a new focused session
	Given I launch the windows clock app
	When  I click on the Focus Session tab
	And   I click the start session button
	Then the pause button is displayed
