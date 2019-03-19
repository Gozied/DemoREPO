Feature: Create A New User
	In order to use the website, i need to be 
	able to create a new user 

Background: 
    Given i am on the account creation page
	

@mytag
Scenario: Sucessfully create a new user
	And I enter my first name
	And i also enter my last name
	And then i enter an email address
	And i enter a telephone number
	And i enter a valid passWord
	And i then confirm the password
	And i opt to subscribe fot the newsletter
	And i agree to privacy
	When i select the continue button
	Then my account should be created
	And  i can log out
	And i can confirm am on the logout page


	Scenario: fail to create user if mandatory field is not completed
	And I enter my first name
	And i also enter my last name
	And then i enter an email address
	And i enter a telephone number
	And i enter a valid passWord
	But i then fail to confirm the password
	And i opt to subscribe fot the newsletter
	And i agree to privacy
	When i select the continue button
	Then my account should be created
	And  i can log out
	And i can confirm am on the logout page