Feature: Change password

Scenario: A. User able to Change Password
Given  User able to login mars portal
Then if User wants to change password '<PasswordPath>' then must be able to change successfully.

Examples: 
| PasswordPath      |
| PasswordFile.json |

