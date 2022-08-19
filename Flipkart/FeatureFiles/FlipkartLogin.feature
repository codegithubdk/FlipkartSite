Feature: FlipkartLogin
	Test the Flipkart Login feature

@mytag

Scenario Outline: Flipkart Login  verification
	When Enter Email<Email> and Password<Password>
	And Click on Login Button
	Then New page should appear
	When Enter the Phone Number <Phone> and click on Continue button
	Then Ask to ReEnter Password <Password>
	When  Click on Login button after enter password
	Then Homepage should open

	@source:Flipkart_Data.xlsx:LoginData
	Examples: 
	 |Email |Password| Phone|

