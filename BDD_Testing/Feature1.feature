Feature: Feature1
	In order to read my emails, I need to be logged in to my gmail


Scenario: Log In
	Given I navigate to "https://www.gmail.com"
	Given I enter username "example"
	Then I click Next button
	And I enter password
	Then I click Next button
	Then I am logged in
