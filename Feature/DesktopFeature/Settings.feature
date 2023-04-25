Feature: SettingsFeature

@driver:desktop
Scenario: Negative testing for signing in when account is already logged in
	Given I launch the windows clock app
	When  I click on the Settings tab
	Then  The sign in button is displayed 