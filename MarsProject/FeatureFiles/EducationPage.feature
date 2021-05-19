Feature: Functionality around Education Tab

	
@mytag
Scenario: I am able to create education details
	Given I have logged in
	And I click on the education tab
	And I click add new button for the education
	And I enter the details for new education
	When I click add button to save new education
    Then Validate the education is created

@mytag
Scenario: I am edit education details
	Given I have logged in
    And I click on the education tab	
    And I click edit icon to edit education
    When I enter the details for edited education details
    And I click update button to save edited education
    Then Validate the edited education is created

@mytag
Scenario: I am able to delete education
	Given I have logged in
    And I click on the education tab	
    And I click delete icon to delete education
    Then I Validate the delete education


