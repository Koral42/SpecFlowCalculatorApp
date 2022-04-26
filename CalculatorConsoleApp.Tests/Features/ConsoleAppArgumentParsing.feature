Feature: ConsoleAppArgumentParsing
	Simple calculator for adding two numbers

@mytag
Scenario: Correctly parses add two numbers
	Given the console app array contains
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

Scenario: When Argv is Empty
	Given an empty argv array
	When console app is executed
	Then the console app fails