Feature: ShareSkill
	Seller wants to add the Skills to the already added listing.
@mytag
Scenario: I want to share my skills with others
	Given I Launched the application 
    And I Click Login link
    When I enter "sidra_riz@yahoo.com" in username and "sid6638659" in password field
    And I click on Login Button
	And I click ShareSkill Button
	When I enter "Digital Marketing" in Title and "Description Digital Marketing" in Description field
	And I enter "Writing & Translation" in Category,"Proof Reading & Editing" in SubCategory 
	And "Digital" in Tags
	And I select "One-off service" in Service Type and "On-line" in Location Type
	And I pick "25-01-2022" in Startdate and "25-02-2022" in Enddate
	And I pick "14:20" in StartTime and "20:30" in Endtime
	And I select "Skill-exchange" in SkillTrade and add "Marketing" Tag in Skill-Exchange
	And I select "Active" in Active field
	And Click Save button
	Then my listing should be available to view

Scenario: I want to edit my Skill listing on Manage Listing Page

    Given I Launched the application 
    And I Click Login link
    When I enter "sidra_riz@yahoo.com" in username and "sid6638659" in password field
    And I click on Login Button
	And I click on Manage Listings Tab
	And I click on Edit Icon on last added Listing
	And I updated "Programming" in Title and "Programming with C" in Description field
	And I updated "Business" in Category,"Business Tips" in SubCategory 
	And I Click Save button
	Then my updated listing should be avalable to view



    


	