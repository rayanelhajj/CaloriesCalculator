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

Scenario Outline: Calculate activity calories for medium active user
	Given I have calculated my <basicCalories>
	And I have entered my <activity>
	When I press calculate activity needs
	Then the result should be <activity_needs> 

Examples:
| basicCalories | activity | activity_needs |
| 1432          | 1        | 429.6          |
| 1331          | 1        | 399.3          |
| 1757          | 1        | 527.1          |

Scenario Outline: Calculate activity calories for highly active user
	Given I have calculated my <basicCalories>
	And I have entered my <activity>
	When I press calculate activity needs
	Then the result should be <activity_needs> 

Examples:
| basicCalories | activity | activity_needs |
| 1432          | 2        | 572.8          |
| 1331          | 2        | 532.4          |
| 1757          | 2        | 702.8          |

Scenario Outline: Calculate activity calories for extremely active user
	Given I have calculated my <basicCalories>
	And I have entered my <activity>
	When I press calculate activity needs
	Then the result should be <activity_needs> 

Examples:
| basicCalories | activity | activity_needs |
| 1432          | 3        | 716.0          |
| 1331          | 3        | 665.5          |
| 1757          | 3        | 878.5          |
