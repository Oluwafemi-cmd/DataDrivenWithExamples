Feature: DataDrivenWithExamples

As a user
In order to enjoy the benefit of this website , i should be able to signup

@tag1
Scenario Outline: Data Driven With Example
	Given I navigate to the website "https://angularjs.realworld.io/"
	And I click on sign up
	And I enter username "<Username>"
	And I enter email "<Email>"
	And I enter password "<Password>"
	When I click on sign up button 
	Then I should be able to register successfully

	Examples: 
	|Username  | Email             | Password |
	|Hary9     |oolua89@gmail.com  |Oloba62641|
	|Wlly8     |bbakosi906@aol.com |Managa78|
	|Pbarma578 |outfa89@aol.com    |Pana890|
	