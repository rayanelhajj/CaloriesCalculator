Feature: CalculateBasicCalories
	In order to know my basic energy needs
	As a user
	I want to calculate my basic calories intake

Scenario Outline:  Calculate basic calories for a male aged between 18 and 30
Given I have entered <age> and <gender> and <weight>
When  I press calculate basic calories
Then the result should be <calories> on the screen

Examples:
| age | gender | weight | calories |
| 18  | 0      | 70     | 1757     |
| 22  | 0      | 70     | 1757     |
| 29  | 0      | 70     | 1757     |

Scenario Outline:  Calculate basic calories for a female aged between 18 and 30
Given I have entered <age> and <gender> and <weight>
When  I press calculate basic calories
Then the result should be <calories> on the screen

Examples:
| age | gender | weight | calories |
| 18  | 1      | 70     | 1525     |
| 22  | 1      | 70     | 1525     |
| 29  | 1      | 70     | 1525     |

Scenario Outline: Calculate basic calories for a male aged between 30 and 60
Given I have entered <age> and <gender> and <weight>
When  I press calculate basic calories
Then  the result should be <calories> on the screen

Examples:
| age | gender | weight | calories |
| 30  | 0      | 70     | 1691     |
| 45  | 0      | 70     | 1691     |
| 59  | 0      | 70     | 1691     |

Scenario Outline: Calculate basic calories for a female aged between 30 and 60
Given I have entered <age> and <gender> and <weight>
When  I press calculate basic calories
Then  the result should be <calories> on the screen

Examples:
| age | gender | weight | calories |
| 30  | 1      | 70     | 1438     |
| 45  | 1      | 70     | 1438     |
| 59  | 1      | 70     | 1438     |

Scenario Outline: Calculate basic calories for a male aged 60 or older
Given I have entered <age> and <gender> and <weight>
When  I press calculate basic calories
Then  the result should be <calories> on the screen

Examples:
| age | gender | weight | calories |
| 60  | 0      | 70     | 1432     |
| 78  | 0      | 70     | 1432     |
| 83  | 0      | 70     | 1432     |
| 101 | 0      | 70     | 1432     |

Scenario Outline: Calculate basic calories for a female aged 60 or older
Given I have entered <age> and <gender> and <weight>
When  I press calculate basic calories
Then  the result should be <calories> on the screen

Examples:
| age | gender | weight | calories |
| 60  | 1      | 70     | 1331     |
| 78  | 1      | 70     | 1331     |
| 83  | 1      | 70     | 1331     |
| 101 | 1      | 70     | 1331     |
