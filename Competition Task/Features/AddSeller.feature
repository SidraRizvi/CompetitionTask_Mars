Feature: add Seller detail
Seller wants to add Skills,Language,Education and Certification to his profile
On adding them it should be reflected on his dashboard

@Home@Profile@SkillTab@AddNewSkill
Scenario Outline: I want to add new Skills to my Profile and all the added Skills should be displayed on my Skill list
	  
    Given I Launched the application 
    And I Click Login link
    When I enter "sidra_riz@yahoo.com" in username and "sid6638659" in password field
    And I click on Login Button
    Then I should be directed to profile page     
    Given I am on Skill Tab of my Profile
    When I enter <SkillName> in txt box
    And I enter <SkillLevel> in dropdown
    And I Click Add Button 
    Then Verify the <Message> should be available on screen
    Examples: 
  | SkillName         | SkillLevel               |       Message                                  |
  |                   | Choose Skill Level       | Please enter skill and experience level        |
  | Graphic Design    | Choose Skill Level       | Please enter skill and experience level        |
  |                   | Expert                   | Please enter skill and experience level        |
  | Graphic Design    | Beginner                 | Graphic Deign has been added to your skills    |
  | Digital Marketing | Beginner                 | Digital Marketing has been added to your skills|
  | Graphic Design    | Beginner                 | This skill already exist in your skill list    |
  | Graphic Design    | Intermediate             | Duplicated Data                                |
 
 
 Scenario: I want to delete added Skill record and the record should not exist on deletion

  Given I Launched the application 
  And I Click Login link
  When I enter "sidra_riz@yahoo.com" in username and "sid6638659" in password field
  And I click on Login Button
  Then I should be directed to profile page     
  Given I am on Skill Tab of my Profile
  When I click Delete Icon of last added Skill
  Then verify that record has been deleted
 
 