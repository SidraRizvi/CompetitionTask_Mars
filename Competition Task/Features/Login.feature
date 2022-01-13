Feature: Seller Login
In order to add profile details
As a registered member
Seller need to login with correct credentials

@Home
Scenario:  When I enter correct credentials I should be successfully loginIn
    
    Given I Launched the application 
    And I Click Login link
    When I enter "sidra_riz@yahoo.com" in username and "sid6638659" in password field
    And I click on Login Button
    Then I should be directed to profile page

@Home@Join	 
Scenario Outline: On filling my details on Joining form I should be registered successfully
     
   Given I Launched the application
   And I click on Join Button
   When I fill the form with <Firstname> <Lastname> <Emailaddress> <Password> and <Confirmpassword> 
   And Check the Terms and conditions box
   And I Click the Join button
   Then <Message> should be displayed
   And I should be directed to the SignIn page

  Examples:   
      | Firstname | Lastname | Emailaddress        | Password   | Confirmpassword | Message                                                 |
      | 123456    | Rizvi    | sidra_riz@yahoo.com | sid6638659 | sid6638659      | Names must contain at least one letter                  |
      | #$%@#     | Rizvi    | sidra_riz@yahoo.com | sid6638659 | sid6638659      | Names must contain at least one letter                  |
      |           | Rizvi    | sidra_riz@yahoo.com | sid6638659 | sid6638659      | This is a required field                                |
      | 123$@^    | Rizvi    | sidra_riz@yahoo.com | sid6638659 | sid6638659      | Names must contain at least one letter                  |
      | Sidra     | Rizvi    | sidra_riz@yahoo.com | sid6638659 | sid6638659      | Registeration sucessful                                 |
      | Sidra     | Rizvi    | sidra_riz@yahoo.com | sid6638659 | sid6638659      | This name has already been used to register an account  |
      | Sidra     | 123456   | sidra_riz@yahoo.com | sid6638659 | sid6638659      | Names must contain at least one letter                  |
      | Sidra     | #$%@#    | sidra_riz@yahoo.com | sid6638659 | sid6638659      | Names must contain at least one letter                  |
      | Sidra     | 123$@^   | sidra_riz@yahoo.com | sid6638659 | sid6638659      | Names must contain at least one letter                  |
      | Sidra     |          | sidra_riz@yahoo.com | sid6638659 | sid6638659      | This is a required field                                |
      | Sidra     | Rizvi    | sidra_riz@yahoo.com | sid6638659 | sid6638659      | This email has already been used to register an account |
      | Sidra     | Rizvi    | abcd@123.com        | 123456     | 123456          | This email is not valid                                 |
      | Sidra     | Rizvi    | abcd123.com         | 123456     | 123456          | Please enter a valid email address                      |
      | Sidra     | Rizvi    |                     | 123456     | 123456          | This is a required field                                |
      | Sidra     | Rizvi    | sidra_riz@yahoo.com | 12345      | 12345           | Password must be at least 6 characters                  |
      | Sidra     | Rizvi    | sidra_riz@yahoo.com |            |                 | These fields are required                               |
      | Sidra     | Rizvi    | sidra_riz@yahoo.com | 1234567    | 123456          | password does not match password                        |
      | Sidra     | Rizvi    | sidr_riz@yahoo.com  | 123&*%     | 123&*%          | Registeration sucessful                                 |
      | Sidra     | Rizvi    | sidra_riz@yahoo.com | 123456     | 1234567         | Does not match password                                 |
