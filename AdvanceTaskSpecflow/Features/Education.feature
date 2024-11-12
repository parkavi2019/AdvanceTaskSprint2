Feature: Education
Scenario: A.add a Education to user profile
Given User navigate to the EducationTab
Then Create a add Education '<EducationPath>' into user profile successfully 

Examples: 
|EducationPath|
|AddEducationfile.json|

Scenario: B.Delete Education to user profile
Given User navigate to the Educationtab
Then User able to deleted '< EducationPath>' education successfully
Examples: 
| EducationPath            |
| DeleteEducationfile.json |

