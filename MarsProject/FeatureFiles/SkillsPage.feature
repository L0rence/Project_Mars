Feature: Funtionality around Skills Tab 
	
 
Scenario: I am able to create skill details
	Given I am logged into
     And I click on the skills tab
    And I click add new button for the skills
    And I enter the details for new skills
    And I click add button to save new skills
    Then Validate the skills is created
 
Scenario: I am edit skill details
	Given I am logged into
    And I click on the skills tab
    And I click edit icon to edit skills
    And I enter the details for edited skill details
    And I click update button to save edited skills
    Then Validate the edited skills is created
 
Scenario: I am able to delete skills
	Given I am logged into
   And I click on the skills tab
    And I click delete icon to delete skills 
    Then I Validate the delete skill
    