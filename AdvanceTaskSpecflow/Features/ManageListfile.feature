Feature: ManageList
Scenario: A.User able to edit managelist in profile
Given User Navigate to the ManageListingsTab
Then user able edit list'<ManageListPath>' successfully
Examples: 
| ManageListPath      |
| ManageListfile.json |

Scenario: B.User able to view the managelist profile
Given User navigate to the ManageListingsTab
Then user able to view the profile list

Scenario: C.User able to delete the managelist
Given User Navigate to the manageListingsTab
Then user able to delete the list

Scenario: D.user able to toggle click checkbox managelist
Given User navigate to the ManagelistingsTab
Then user able to click toggle checkbox enable 

Scenario: E.User able to Toggle click checkBox manageList
Given  user able to enter to the manageListingtab
Then  user able to click toggle checkbox disable

Scenario: F.User able to Update managlist in profile
Given user Navigate to the ManageListingsTab
Then  user able to update '<ManageListPath>' successfully
Examples: 
| ManageListPath        |
| UpdateManageList.json |
