Feature: ConsoleAppArgumentParsing
	Simple calculator for adding two numbers

@mytag
Scenario: Add two number
	Given an epmty arg v array containting
	| Value |
	| add   |
    | 70    |
	| 50    |
	When console app is passed argv 
	Then console apps opperator is "add"
	And console apps values contains 70
	And console apps values contains 50
	And counsel apps result should be 120