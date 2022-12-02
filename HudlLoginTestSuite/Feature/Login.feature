Feature: Login
As a Hudl platform user
I want to check the login functionality
So the user can login and browse the platform

Background: 
Given The user launches the application
And the user clicks on the Login button on home page
And the user is redirected to the login page


@LoginPage
Scenario: User successfuly logs in	
	When the user enters credentials
	| Email    | Password  |
	| <UEmail> | <UPasswd> |
	And Clicks login button
	Then the user is logged in

@LoginPage
Scenario: Un-successfull log in attempts 
	When the user enters credentials
	| Email | Password |
	|       |          |
	|       | pwd      |
	And Clicks login button
	Then the user is not logged in

@ResetPasswordPage
Scenario: Reset password for registered users
Given a user navigates to the reset password page
And the user can see the reset password page
When the user enters their EmailId
| Email                        |
| anushaarunkulkarni@gmail.com |
And user clicks Resend Password button
Then the user receives a success message

@ResetPasswordPage
Scenario: Reset password for un-registered users
Given a user navigates to the reset password page
And the user can see the reset password page
When the user enters their EmailId
| Email |
| ll    |
And user clicks Resend Password button
Then the user receives an error message

@OrgPage
Scenario: Successful login through organisation account
Given the user clicks Login with an organisation button
When the user enters their email id in org email field
| Email              |
| <ValidOrgEmail> |
And clicks on Login 
Then user is successfully logged in

@OrgPage
Scenario: Un-successful Org login atempt for user that are not set up for org login
Given the user clicks Login with an organisation button
And the user can see the org login page
When the user enters their email id in org email field
| Email                        |
| anushaarunkulkarni@gmail.com |
And clicks on Login 
Then the user is redirecetd to the login page
And the user can see an org error message

@LoginPage
Scenario: Verify the other webelements present on the login page
Then user can see the back arrow icon which navigates back to home page
And user can see the SingUp hyperlink which navigates to the Singup page
And the user can see the Hudl logo
And the user can see the remember me check box for checking and un-checking

