Feature: Calculator Example
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario: Add two numbers
	Given I start instance №'1' of 'Calc1'	
	And In №'1' of 'Calc1' I have entered '50' into the calculator 
	And In №'1' of 'Calc1' I press add
	And In №'1' of 'Calc1' I have entered '70' into the calculator 
		When In №'1' of 'Calc1' I press result
			Then In №'1' of 'Calc1'the result should be '120' on the screen

Scenario: Multi instance work
	Given I start instance №'1' of 'Calc1'	
	Given I start instance №'2' of 'Calc1'	
	And In №'1' of 'Calc1' I have entered '50' into the calculator 
	And In №'1' of 'Calc1' I press add
	And In №'1' of 'Calc1' I have entered '70' into the calculator 
		When In №'1' of 'Calc1' I press result
			Then In №'1' of 'Calc1'the result should be '120' on the screen
	Given In №'1' of 'Calc1' I copy result to clipboard
	And In №'2' of 'Calc1' I have entered '50' into the calculator 
	And In №'2' of 'Calc1' I press add
	And In №'2' of 'Calc1' I insert value from clipboard  			
		When In №'2' of 'Calc1' I press result
			Then In №'2' of 'Calc1'the result should be '170' on the screen		 