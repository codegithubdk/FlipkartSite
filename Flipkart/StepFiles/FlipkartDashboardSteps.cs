using Flipkart.UtilityClass;
using System;
using TechTalk.SpecFlow;

namespace Flipkart.StepFiles
{
    [Binding]
    public class FlipkartDashboardSteps:Dashboard_Navbar
    {

        LoginPage log = new LoginPage();
        Dashboard_Navbar d1 = new Dashboard_Navbar();


        [When(@"login with correct credentials(.*),(.*) and (.*)")]
        public void WhenLoginWithCorrectCredentialsAnd(string Email, string Password, string Phone)
        {
           log.Uptologin(Email, Password, Phone);
        }

        
        [Then(@"Flipkart home page should open")]
        public void ThenFlipkartHomePageShouldOpen()
        {
            Console.WriteLine(" Redirected to  Home page");
        }


        [Then(@"Verify Flipkart logo on left top of home page")]
        public void ThenVerifyFlipkartLogoOnLeftTopOfHomePage()
        {
           d1. ValidateLogo();
        }

        //scenario search bar 2.

        [Then(@"verify Search bar by entering product name (.*) on search bar \.")]
        public void ThenVerifySearchBarByEnteringProductNameOnSearchBar_(string product)
        {
            d1.ValidateSearchbar(product);
            

        }

        //Scenario My profile section 3.

        [Then(@"click on My profile  under user's name dropdown\.")]
        public void ThenClickOnMyProfileUnderUserSNameDropdown_()
        {
            d1.ValidateMyProfile();
        }

        [Then(@"verify My profile page\.")]
        public void ThenVerifyMyProfilePage_()
        {
            d1.MatchUsrname();
        }

        //Scenario of Supercoin Zone

        [Then(@"click on Supercoin Zone  under user's name dropdown\.")]
        public void ThenClickOnSupercoinZoneUnderUserSNameDropdown_()
        {
            d1.ValidateCoinZone();
        }

        [Then(@"verify Supercoin Zone page\.")]
        public void ThenVerifySupercoinZonePage_()
        {
            d1.MatchCoinZonePage();
        }

        //Scenario of Plus zone

        [Then(@"click on Flipkart Plus Zone  under user's name dropdown\.")]
        public void ThenClickOnFlipkartPlusZoneUnderUserSNameDropdown_()
        {
            d1.ValidateplusZone();
        }

        [Then(@"verify Plus Zone page\.")]
        public void ThenVerifyPlusZonePage_()
        {
            d1.FlipkartPlusZone();
           // Console.WriteLine("flipkart plus Zone page open.");
        }

        // Scenario of Orders section

        [Then(@"click on Flipkart orders  under user's name dropdown\.")]
        public void ThenClickOnFlipkartOrdersUnderUserSNameDropdown_()
        {
            d1.ValidateOrders();
        }

        [Then(@"verify orders  page\.")]
        public void ThenVerifyOrdersPage_()
        {
            d1.OrdersPage();
        }

        //scenario of Wishlists

        [Then(@"click on Flipkart wishlists  under user's name dropdown\.")]
        public void ThenClickOnFlipkartWishlistsUnderUserSNameDropdown_()
        {
            d1.ValidateWishlists();
        }

        [Then(@"verify wishlists  page\.")]
        public void ThenVerifyWishlistsPage_()
        {
            d1.WishlistPage();
        }

        //Scenario of My Chats 

        [Then(@"click on Flipkart My chats  under user's name dropdown\.")]
        public void ThenClickOnFlipkartMyChatsUnderUserSNameDropdown_()
        {
            d1.ValidateMyChats();
        }

        [Then(@"verify My chats  page\.")]
        public void ThenVerifyMyChatsPage_()
        {
            d1.MyChatsPage();
        }

        //Scenario of Cupons

        [Then(@"click on Flipkart Coupons  under user's name dropdown\.")]
        public void ThenClickOnFlipkartCouponsUnderUserSNameDropdown_()
        {
            d1.ValidateCupons();
        }

        [Then(@"verify Coupons  page\.")]
        public void ThenVerifyCouponsPage_()
        {
            d1.CuponsPage();
        }

        //Scenario of giftcards

        [Then(@"click on Flipkart Gift Cards  under user's name dropdown\.")]
        public void ThenClickOnFlipkartGiftCardsUnderUserSNameDropdown_()
        {
            d1.ValidateGiftCards();
        }

        [Then(@"verify Gift Cards  page\.")]
        public void ThenVerifyGiftCardsPage_()
        {
            d1.GiftCardsPage();
        }

        //scenario of Nitifications

        [Then(@"click on Flipkart Notifications  under user's name dropdown\.")]
        public void ThenClickOnFlipkartNotificationsUnderUserSNameDropdown_()
        {
            d1.Validatenitofications();
        }

        [Then(@"verify Notifications  page\.")]
        public void ThenVerifyNotificationsPage_()
        {
            d1.notificationPage();
        }

        //Scenario of Logout

        [Then(@"click on Flipkart Logout  under user's name dropdown\.")]
        public void ThenClickOnFlipkartLogoutUnderUserSNameDropdown_()
        {
            d1.ValidatelogoutButton();
        }

        [Then(@"verify Logout  page\.")]
        public void ThenVerifyLogoutPage_()
        {
            d1.ReturnToHomePage();
        }

        //Scenario of Become a seller section

        [Then(@"click on Flipkart's Become a seller section in home page")]
        public void ThenClickOnFlipkartSBecomeASellerSectionInHomePage()
        {
            d1.ValidateSellerButton();
        }

        [Then(@"verify Become a seller  page\.")]
        public void ThenVerifyBecomeASellerPage_()
        {
            d1.SellerPage();
        }

        //Scenario of Nitification preferences

        [Then(@"click on Flipkart's Notifications Preferences section under More dropdown\.")]
        public void ThenClickOnFlipkartSNotificationsPreferencesSectionUnderMoreDropdown_()
        {
            d1.ValidateNotiPreferences();
        }

        [Then(@"verify Notifications Preferences  page\.")]
        public void ThenVerifyNotificationsPreferencesPage_()
        {
            d1.NotifPreferencesPg();
        }

        //Scenario of 24*7 customer care

        [Then(@"click on Flipkart's (.*) Customer Care section under More dropdown\.")]
        public void ThenClickOnFlipkartSCustomerCareSectionUnderMoreDropdown_(string p0)
        {
            d1.ValidateCustomerCare();
        }

        [Then(@"verify (.*) Customer Care  page\.")]
        public void ThenVerifyCustomerCarePage_(string p0)
        {
            d1.CustomerCarePg();
        }

        //Scenario of Advertise section

        [Then(@"click on Flipkart's Advertise section under More dropdown\.")]
        public void ThenClickOnFlipkartSAdvertiseSectionUnderMoreDropdown_()
        {
            d1.ValidateAdvertiseSection();
        }

        [Then(@"verify Advertise  page\.")]
        public void ThenVerifyAdvertisePage_()
        {
            d1.AdvertiseSectionPg();
        }

        //Scenario of Download App

        [Then(@"click on Flipkart's Download app section under More dropdown\.")]
        public void ThenClickOnFlipkartSDownloadAppSectionUnderMoreDropdown_()
        {
            d1.ValidateDownloadAppSection();
        }

        [Then(@"verify Download app  page\.")]
        public void ThenVerifyDownloadAppPage_()
        {
            d1.DownloadAppPg();
        }

        //Scenario of Cart section

        [Then(@"click on Flipkart's Cart section in home page")]
        public void ThenClickOnFlipkartSCartSectionInHomePage()
        {
            d1.ValidateCartSection();
        }

        [Then(@"verify Cart  page\.")]
        public void ThenVerifyCartPage_()
        {
            d1.CartPage();
        }








    }
}
