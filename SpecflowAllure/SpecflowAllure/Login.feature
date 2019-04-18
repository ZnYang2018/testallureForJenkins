Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@package:Login
@testClass:login app
@testMethod:login app01
Scenario: login app
	Given I have opened the app
	And I login in with username and password
	When I press login button
	Then I should see home page
