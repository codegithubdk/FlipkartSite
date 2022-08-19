Feature: FlipkartDashboard
	Test the Flipkart dashboard page

@mytag

Scenario Outline: To check the Flipkart logo .
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  Then  Verify Flipkart logo on left top of home page

  @source:Flipkart_Data.xlsx:LoginData
	Examples: 
    |Email |Password| Phone|


Scenario Outline: To check the Flipkart Search Bar.
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  Then  verify Search bar by entering product name <Product> on search bar .

  @source:Flipkart_Data.xlsx:SearchData
	Examples: 
    |Email |Password| Phone|Product|


Scenario Outline: To check the Flipkart My profile section under Login dropdown.
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  And  click on My profile  under user's name dropdown.
  Then  verify My profile page.


  @source:Flipkart_Data.xlsx:LoginData
	Examples: 
    |Email |Password| Phone|


Scenario Outline: To check the Flipkart Supercoin Zone section under Login dropdown.
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  And  click on Supercoin Zone  under user's name dropdown.
  Then  verify Supercoin Zone page.


  @source:Flipkart_Data.xlsx:LoginData
	Examples: 
    |Email |Password| Phone|


Scenario Outline: To check the Flipkart Plus Zone section under Login dropdown.
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  And  click on Flipkart Plus Zone  under user's name dropdown.
  Then  verify Plus Zone page.


  @source:Flipkart_Data.xlsx:LoginData
	Examples: 
    |Email |Password| Phone|


Scenario Outline: To check the Flipkart orders section under Login dropdown.
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  And  click on Flipkart orders  under user's name dropdown.
  Then  verify orders  page.


  @source:Flipkart_Data.xlsx:LoginData
	Examples: 
    |Email |Password| Phone|


Scenario Outline: To check the Flipkart wishlists section under Login dropdown.
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  And  click on Flipkart wishlists  under user's name dropdown.
  Then  verify wishlists  page.


  @source:Flipkart_Data.xlsx:LoginData
	Examples: 
    |Email |Password| Phone|


Scenario Outline: To check the Flipkart My chats section under Login dropdown.
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  And  click on Flipkart My chats  under user's name dropdown.
  Then  verify My chats  page.


  @source:Flipkart_Data.xlsx:LoginData
	Examples: 
    |Email |Password| Phone|


Scenario Outline: To check the Flipkart Coupons section under Login dropdown.
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  And  click on Flipkart Coupons  under user's name dropdown.
  Then  verify Coupons  page.


  @source:Flipkart_Data.xlsx:LoginData
	Examples: 
    |Email |Password| Phone|


Scenario Outline: To check the Flipkart Gift Cards section under Login dropdown.
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  And  click on Flipkart Gift Cards  under user's name dropdown.
  Then  verify Gift Cards  page.


  @source:Flipkart_Data.xlsx:LoginData
	Examples: 
    |Email |Password| Phone|


Scenario Outline: To check the Flipkart Notifications section under Login dropdown.
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  And  click on Flipkart Notifications  under user's name dropdown.
  Then  verify Notifications  page.


  @source:Flipkart_Data.xlsx:LoginData
	Examples: 
    |Email |Password| Phone|


Scenario Outline: To check the Flipkart Logout section under Login dropdown.
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  And  click on Flipkart Logout  under user's name dropdown.
  Then  verify Logout  page.


  @source:Flipkart_Data.xlsx:LoginData
	Examples: 
    |Email |Password| Phone|


Scenario Outline: To check the Flipkart Become a seller section in right-top of home page.
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  And  click on Flipkart's Become a seller section in home page
  Then  verify Become a seller  page.


  @source:Flipkart_Data.xlsx:LoginData
	Examples: 
    |Email |Password| Phone|


Scenario Outline: To check the Flipkart Notifications Preferences section under More dropdown.
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  And  click on Flipkart's Notifications Preferences section under More dropdown.
  Then  verify Notifications Preferences  page.


  @source:Flipkart_Data.xlsx:LoginData
	Examples: 
    |Email |Password| Phone|


Scenario Outline: To check the Flipkart 24*7 Customer Care section under More dropdown.
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  And  click on Flipkart's 24*7 Customer Care section under More dropdown.
  Then  verify 24*7 Customer Care  page.


  @source:Flipkart_Data.xlsx:LoginData
	Examples: 
    |Email |Password| Phone|


Scenario Outline: To check the Flipkart Advertise section under More dropdown.
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  And  click on Flipkart's Advertise section under More dropdown.
  Then  verify Advertise  page.


  @source:Flipkart_Data.xlsx:LoginData
	Examples: 
    |Email |Password| Phone|


Scenario Outline: To check the Flipkart Download app section under More dropdown.
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  And  click on Flipkart's Download app section under More dropdown.
  Then  verify Download app  page.


  @source:Flipkart_Data.xlsx:LoginData
	Examples: 
    |Email |Password| Phone|


Scenario Outline: To check the Flipkart Cart section in right-top of home page.
  When  login with correct credentials<Email>,<Password> and <Phone>
  Then  Flipkart home page should open
  And  click on Flipkart's Cart section in home page
  Then  verify Cart  page.


  @source:Flipkart_Data.xlsx:LoginData
	Examples: 
    |Email |Password| Phone|



	

	
  

  


