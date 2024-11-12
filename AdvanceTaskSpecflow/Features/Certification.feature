Feature: Certification
Scenario: A.Add a Certification to user profile
Given User Navigate to the CertificationTab
Then Create a add Certification '<CertificationPath>' into user profile successfully

Examples: 
| CertificationPath    |
| AddCertificationfile.json | 

Scenario: B.Delete Certification to user profile
Given User Navigate to the Certificationtab
Then User able to Delted'<CertificationPath>' Certification successfully
Examples: 
| CertificationPath    |
| DeleteCertificationfile.json | 
