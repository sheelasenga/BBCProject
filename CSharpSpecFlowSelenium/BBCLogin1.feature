Feature: BBCLogin1
In order to login into my account
As a user
I want to be able to see my account page


Scenario: Invalid password
    Given I am on the login page
    And I have enter a valid username
    And I have entered a invalid password
    When I press login
    Then I should see the appropriate error

Scenario: Valid password
    Given I am on the bbc login page 
    And I have entered a valid username
    And I have entered a valid password
    When I press login btn
    Then I should see the user account homepage
	
Scenario: successful sign out
  Given i am on the account page
  When i press the sign out button
  Then i should see the sign out page



	
