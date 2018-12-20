Feature: CalculateActivityNeedsCalories
	In order to know my Activity level calories burned
	As a user
	I want to calculate my activity energy needs in calories
  
@mytag
Scenario Outline: Calculate activity calories for lightly active user
	Given I have calculated my <basicCalories>
	And I have entered my <activity>
	When I press calculate activity needs
	Then the result should be <activity_needs> 

Examples:
| basicCalories | activity | activity_needs |
| 1432          | 0        | 286.4          |
| 1331          | 0        | 266.2          |
| 1757          | 0        | 351.4          |
