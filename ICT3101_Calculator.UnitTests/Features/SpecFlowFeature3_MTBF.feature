Feature: UsingCalculatorAvailability
	In order to calculate MTBF and Availability
	As someone who struggles with math
	I want to be able to use my calculator to do this

@Availability
Scenario: Calculating MTBF
	Given I have a calculator
	When I have entered "1" and "1" into the calculator and press MTBF
	Then the availability result should be "2"

@Availability
Scenario: Calculating Availability
	Given I have a calculator
	When I have entered "5" and "10" into the calculator and press Availability
	Then the availability result should be "50"

@Availability
Scenario: Calculating Availability with negative value
	Given I have a calculator
	When I have entered "-1" and "1" into the calculator and press Availability
	Then the availability result should be an error message