Feature: functionality around Language Tab
 
Scenario: I am able to create language
	Given I am logged in
    #And I am at the language tab
    And I click add new button for the language
    And I enter the details for new language
    And I click add button to save new language
    Then Validate the language is created
    
 
Scenario: I am able to edit language
	Given I am logged in
    #And I am at the language tab
    And I click edit icon to edit language
    And I enter the details for edited language
    And I click update button to save edited language
    Then Validate the edited language is created
 
Scenario: I am able to delete language
	Given I am logged in
    #And I am at the language tab
    And I click delete icon to delete language 
   Then Validate the delete language is deleted