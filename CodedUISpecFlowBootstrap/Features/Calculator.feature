Feature: Calculator Example
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I start instance №'1' of 'Calc1'	
	Given I start instance №'2' of 'Calc1'
	When In 'Calc1' №'1' I open View menu
	Then Wait 10000
	When In 'Calc1' №'1' I click on EngineeringButton
	Then Wait 10000
	When In 'Calc1' №'1' I open Help menu
	Then Wait 10000
	When In 'Calc1' №'2' I open View menu
	Then Wait 10000
