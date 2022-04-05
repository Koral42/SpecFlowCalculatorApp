Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@mytag
Scenario: Add two Numbers
	When Console App receeives the arguments
	| Value |
	| add   |
	| 70    |
	| 50    |
	Then the result should be 120