Feature: BBCLogin
In order to view the login page
As a user
I want to be able to see website

@mytag 

Scenario: Home page
    Given I am on the home page
    When I press sign in
    Then I should see the login page
