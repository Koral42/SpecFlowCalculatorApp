Feature: ConsoleAppArgumentParsing
	Simple calculator for adding two numbers

@mytag
Scenario: Correctly parses add two numbers
	Given an epmty argv array containting
	| Value |
	| add   |
    | 70    |
	| 50    |
	When console app is passed argv
	Then console apps opperator is "add"
	And console apps values matches 
	| Value |
	| 70    |
	| 50    |