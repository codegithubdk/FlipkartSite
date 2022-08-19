using Flipkart.Common;
using Flipkart.CustomException;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipkart.UtilityClass
{
     public class Dashboard_Navbar  : BasePageImplementation
    {
       // FlipkartException exp = new FlipkartException();
        //public Dashboard_Navbar(IWebDriver driver) : base(driver)
        //{

        //}

        //Locators for Dashboard navbars

         By logo = By.XPath("//div[@id='container']//img[@title='Flipkar']");
         By srchbar = By.XPath("//input[@placeholder='Search for products, brands and more']");

        // By HitSrchBtn = By.XPath("//div[@id='container']//button[@type='submit']");
        public static string HitSrchBtn =("//div[@id='container']//button[@type='submit']");
        

        By Hitprofile = By.XPath("//div[normalize-space()='My Profile']");
         By usrname = By.XPath("//div[contains(text(), 'Deepika')]");
         By PhnDetailsPg = By.XPath("//a[@href='/mobiles/pr?sid=tyy,4io&marketplace=FLIPKAR']");
         By profile = By.XPath("//div[@class='_1ruvv2']");
         By CoinZone = By.XPath("//div[normalize-space()='SuperCoin Zone']");//a[@href='/supercoin']
        By CoinZoneText = By.XPath("//div[@class='_3WWNnl']");
         By PlusZone = By.XPath("//div[normalize-space()='Flipkart Plus Zone']");
        By Orders = By.XPath("//a[@href='/account/orders?link=home_orders']");
         By OrderPg = By.XPath("//div[@class='_2MvS62']");
         By wishlists = By.XPath("//div[normalize-space()='Wishlist']");
        By wishlistsPg = By.XPath("//div[@class='_3FVYY1']");
        By Chats = By.XPath("//div[normalize-space()='My Chats']");
         By ChatsPg = By.XPath("//div[@class='jXdjIv']");
         By Cupons = By.XPath("//div[normalize-space()='Coupons']");
         By CuponsPg = By.XPath("//div[@class='HrTrMw']");
         By Gifts = By.XPath("//div[@class='_3vhnxf'][normalize-space()='Gift Cards']");
         By GiftsPg = By.XPath("//h1[@class='_3vKRL2']");
         By Notifi = By.XPath("//a[@href='/notifications?otracker=Notifications_view_all']");
         By NotifiPg = By.XPath("//div[@class='TQWXTH']");
         By Logout = By.XPath("//div[contains(text(),'Logout')]");
         By HomePg = By.XPath("//a[@class='_1_3w1N']");
         By Seller = By.XPath("//a[@class='_3-PJz-']//span[contains(text(),'Become a Seller')]");
         By SellerPg = By.XPath("//div[@class='styles__RegistrationText-r412un-9 gMTBgI']");

         By MoreButton = By.XPath("//div[@class='exehdJ']");
         By NotiPref = By.XPath("//div[normalize-space()='Notification Preferences']");
         By NotiPrefPg = By.XPath("//div[@class='_2lGsRD']");
         By CustmrCare = By.XPath("//div[normalize-space()='24x7 Customer Care']");
         By CustmrCarePg = By.XPath("//a[@class='_2whKao']");
         By Advertise = By.XPath("//div[contains(text(),'Advertise')]");
         By AdvertisePg = By.XPath("//p[@class='styles__Heading-sc-18s7njp-7 erLrxD']");
         By DwnldApp = By.XPath("//div[normalize-space()='Download App']");
         By DwnldAppPg = By.XPath("//div[@class='_35VkRn']");

         By Cart = By.XPath("//span[normalize-space()='Cart']");
         By CartPg = By.XPath("//a[@class='_2hJxpa']");
        // By DwnldAppPg = By.XPath("//div[@class='_35VkRn']");







        //verify logo
        public void ValidateLogo()
        {

            string val1 = Hooks.driver.FindElement(logo).GetAttribute("alt");

            Console.WriteLine("Logo name provided on website =" + val1);
            // ExplicitWaiting.waitForTime(1000);

            string org = "Flipkart";
            Assert.AreEqual(val1, org);
            // ExplicitWaiting.waitForTime(2000);

            Console.WriteLine(" Logo matched successfully");
            //ExplicitWaiting.waitForTime(1000);
            //try
            //{
            //    string val1 = Hooks.driver.FindElement(logo).GetAttribute("alt");

            //    Console.WriteLine("Logo name provided on website =" + val1);
            //    // ExplicitWaiting.waitForTime(1000);

            //    string org = "Flipkart";
            //    Assert.AreEqual(val1, org);
            //    // ExplicitWaiting.waitForTime(2000);

            //    Console.WriteLine(" Logo matched successfully");
            //    //ExplicitWaiting.waitForTime(1000);
            //}

            //catch (Exception e)
            //{
            //    Console.WriteLine(e.StackTrace);
            //}


        }

                                                                    //verify search bar

        public void ValidateSearchbar(string product)
        {
            //try
            //{
                Hooks.driver.FindElement(srchbar).SendKeys(product);
                Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

               // ExplicitWaiting.waitForTime(8000);
                Hooks.driver.FindElement(By.XPath(HitSrchBtn)).Click();
               FlipkartException.WaitForAnElementUntilClickable(HitSrchBtn);
               
                Console.WriteLine(" Product details page open");

                string val1 = Hooks.driver.FindElement(PhnDetailsPg).Text;
                Console.WriteLine("Phone details page title provided on website =" + val1);

                string org = "Mobiles";
                Assert.AreEqual(val1, org);

                Console.WriteLine("Phone Page title matched  successfully");
                //ExplicitWaiting.waitForTime(1000);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.StackTrace);
            //}

        }

                                                              // verify  My profile

        public void ValidateMyProfile()
        {
            try
            {
                IWebElement element = Hooks.driver.FindElement(usrname);
                Actions action = new Actions(Hooks.driver);
                action.MoveToElement(element).Perform();

                Hooks.driver.FindElement(Hitprofile).Click();
                ExplicitWaiting.waitForTime(8000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void MatchUsrname()
        {

            try
            {
                string val1 = Hooks.driver.FindElement(profile).Text;
                //string str = val1;
                //char[] spearator = { '\n', '\r' };

                //string[] strlist = str.Split(spearator);
                //string Text1 = strlist[1];
                //string Text2 = strlist[2];

                //string Text3 = strlist[1]+strlist[2];

                Console.WriteLine("Username provided on Flipkart's My profile section =" + val1);

                string org = "Deepika Kumari";
                Assert.AreEqual(val1, org);

                Console.WriteLine("Username matched  successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

                                                   // verify supercoin zone

        public void ValidateCoinZone()
        {
            try
            {
                IWebElement element = Hooks.driver.FindElement(usrname);
                Actions action = new Actions(Hooks.driver);
                action.MoveToElement(element).Perform();

                Hooks.driver.FindElement(CoinZone).Click();
                ExplicitWaiting.waitForTime(8000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }

        public void MatchCoinZonePage()
        {
            try
            {
                string val1 = Hooks.driver.FindElement(CoinZoneText).Text;
                string str = val1;
                char[] spearator = { '\n', '\r' };

                string[] strlist = str.Split(spearator);
                string Text1 = strlist[0];

                Console.WriteLine("Title provided on Flipkart's SuperCoin Zone section =" + Text1);

                string org = "SuperCoin Balance";
                Assert.AreEqual(Text1, org);

                Console.WriteLine("SuperCoin Title matched  successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

                                                            // verify Flipkart plus zone

        public void ValidateplusZone()
        {
            try
            {
                IWebElement element = Hooks.driver.FindElement(usrname);
                Actions action = new Actions(Hooks.driver);
                action.MoveToElement(element).Perform();

                Hooks.driver.FindElement(PlusZone).Click();
                ExplicitWaiting.waitForTime(8000);
                //string val1 = Hooks.driver.getTitle();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void FlipkartPlusZone()
        {
            try
            {
                //string val1 = Hooks.driver.FindElement(OrderPg).Text;
                string val1 = Hooks.driver.Title;
                Console.WriteLine("Title provided on Flipkart's PlusZone section =" + val1);

                string org = "Flipkart Plus – The Ultimate Rewards Program for Flipkart Customers | Flipkart.com";
                Assert.AreEqual(val1, org);

                Console.WriteLine("Flipkart's PlusZone Title matched  successfully");
            }            
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

                                                           // verify Orders section

        public void ValidateOrders()
        {
            try
            {
                IWebElement element = Hooks.driver.FindElement(usrname);
                Actions action = new Actions(Hooks.driver);
                action.MoveToElement(element).Perform();

                Hooks.driver.FindElement(Orders).Click();
                ExplicitWaiting.waitForTime(8000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }

        public void OrdersPage()
        {
            try
            {
                string val1 = Hooks.driver.FindElement(OrderPg).Text;
                Console.WriteLine("Title provided on Flipkart's Order section =" + val1);

                string org = "ORDER STATUS";
                Assert.AreEqual(val1, org);

                Console.WriteLine("Orders page Title matched  successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

                                                             // verify Wishlista section

        public void ValidateWishlists()
        {
            try
            {
                IWebElement element = Hooks.driver.FindElement(usrname);
                Actions action = new Actions(Hooks.driver);
                action.MoveToElement(element).Perform();
                //ExplicitWaiting.waitForTime(3000);

                Hooks.driver.FindElement(wishlists).Click();
                ExplicitWaiting.waitForTime(8000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }

        public void WishlistPage()
        {
            try
            {
                string val1 = Hooks.driver.FindElement(wishlistsPg).Text;
                string str = val1;
                char[] spearator = { ' ' };
                string[] strlist = str.Split(spearator);
                string Text1 = strlist[0];
                string Text2 = strlist[1];
                string Text3 = strlist[0] + " " + strlist[1];

                Console.WriteLine("Title provided on Flipkart's Wishlists section =" + Text3);

                //  string val1 = Hooks.driver.FindElement(CoinZoneText).Text;
                //string str = val1;
                // char[] spearator = { '\n', '\r' };

                string org = "My Wishlist";
                Assert.AreEqual(Text3, org);

                Console.WriteLine("Wishlists page Title matched  successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

                                                     // verify MyChats section

        public void ValidateMyChats()
        {
            try
            {
                IWebElement element = Hooks.driver.FindElement(usrname);
                Actions action = new Actions(Hooks.driver);
                action.MoveToElement(element).Perform();

                Hooks.driver.FindElement(Chats).Click();
                ExplicitWaiting.waitForTime(8000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }

        public void MyChatsPage()
        {
            try
            {
                string val1 = Hooks.driver.FindElement(ChatsPg).Text;
                Console.WriteLine("Title provided on Flipkart's MyChats section =" + val1);

                string org = "All Chats";
                Assert.AreEqual(val1, org);

                Console.WriteLine("MyChats page Title matched  successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

                                                                 // verify Cupons section

        public void ValidateCupons()
        {
            try
            {
                IWebElement element = Hooks.driver.FindElement(usrname);
                Actions action = new Actions(Hooks.driver);
                action.MoveToElement(element).Perform();

                Hooks.driver.FindElement(Cupons).Click();
                ExplicitWaiting.waitForTime(8000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }

        public void CuponsPage()
        {
            try
            {
                IList<IWebElement> text1 = Hooks.driver.FindElements(CuponsPg);
                int count = text1.Count;

                string val1 = text1[0].Text;
                Console.WriteLine("Title provided on Flipkart's MyCoupons section =" + val1);

                string org = "Available Coupons";
                Assert.AreEqual(val1, org);

                Console.WriteLine("MyCoupons page Title matched  successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

                                                                  // verify GiftCards section

        public void ValidateGiftCards()
        {
            try
            {
                IWebElement element = Hooks.driver.FindElement(usrname);
                Actions action = new Actions(Hooks.driver);
                action.MoveToElement(element).Perform();

                Hooks.driver.FindElement(Gifts).Click();
                ExplicitWaiting.waitForTime(8000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void GiftCardsPage()
        {
            try
            {
                string val1 = Hooks.driver.FindElement(GiftsPg).Text;
                Console.WriteLine("Title provided on Flipkart's GiftCards section =" + val1);

                string org = "Gift Card Store";
                Assert.AreEqual(val1, org);

                Console.WriteLine("GiftCards page Title matched  successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }


                                                                 // verify Notification section

        public void Validatenitofications()
        {
            try
            {
                IWebElement element = Hooks.driver.FindElement(usrname);
                Actions action = new Actions(Hooks.driver);
                action.MoveToElement(element).Perform();

                Hooks.driver.FindElement(Notifi).Click();
                ExplicitWaiting.waitForTime(8000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }

        public void notificationPage()
        {
            try
            {
                string val1 = Hooks.driver.FindElement(NotifiPg).Text;
                Console.WriteLine("Title provided on Flipkart's Notification section =" + val1);

                string org = "All Notifications";
                Assert.AreEqual(val1, org);

                Console.WriteLine("Notification page Title matched  successfully");
            }
             catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

                                                                     // verify Logout section

        public void ValidatelogoutButton()
        {
            try
            {
                IWebElement element = Hooks.driver.FindElement(usrname);
                Actions action = new Actions(Hooks.driver);
                action.MoveToElement(element).Perform();

                Hooks.driver.FindElement(Logout).Click();
                ExplicitWaiting.waitForTime(8000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void ReturnToHomePage()
        {
            try
            {
                string val1 = Hooks.driver.FindElement(HomePg).Text;
                Console.WriteLine("Button provided on Flipkart's HomePage =" + val1);

                string org = "Login";
                Assert.AreEqual(val1, org);

                Console.WriteLine("Home page  login Button matched  successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

                                                               // verify Become a seller

        public void ValidateSellerButton()
        {
            try
            {
                //IWebElement element = Hooks.driver.FindElement(usrname);
                //Actions action = new Actions(Hooks.driver);
                //action.MoveToElement(element).Perform();

                Hooks.driver.FindElement(Seller).Click();
                ExplicitWaiting.waitForTime(8000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void SellerPage()
        {
            try
            {
                string val1 = Hooks.driver.FindElement(SellerPg).Text;
                Console.WriteLine("Title provided on Flipkart's Become a seller page =" + val1);

                string org = "Launch your business in 10 minutes";
                Assert.AreEqual(val1, org);

                Console.WriteLine("Title of  Become a seller page matched  successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

                                                      // verify Notification Preferences

        public void ValidateNotiPreferences()
        {
            try
            {
                //IWebElement element1 = Hooks.driver.FindElement(MoreButton);

                IList<IWebElement> element1 = Hooks.driver.FindElements(MoreButton);
                int count = element1.Count;

                IWebElement buttons = element1[1];

                Actions action = new Actions(Hooks.driver);
                action.MoveToElement(buttons).Perform();
                ExplicitWaiting.waitForTime(3000);

                Hooks.driver.FindElement(NotiPref).Click();
                ExplicitWaiting.waitForTime(8000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void NotifPreferencesPg()
        {
            try
            {
                string val1 = Hooks.driver.FindElement(NotiPrefPg).Text;
                Console.WriteLine("Title provided on Flipkart's Notification Preferences Page =" + val1);

                string org = "Desktop Notifications";
                Assert.AreEqual(val1, org);

                Console.WriteLine("Title of  Notification Preferences Page matched  successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }


                                                       // verify 24*7 customer care

        public void ValidateCustomerCare()
        {
            try
            {
                //IWebElement element1 = Hooks.driver.FindElement(MoreButton);

                IList<IWebElement> element1 = Hooks.driver.FindElements(MoreButton);
                int count = element1.Count;

                IWebElement buttons = element1[1];

                Actions action = new Actions(Hooks.driver);
                action.MoveToElement(buttons).Perform();

                Hooks.driver.FindElement(CustmrCare).Click();
                ExplicitWaiting.waitForTime(8000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void CustomerCarePg()
        {
            try
            {
                string val1 = Hooks.driver.FindElement(CustmrCarePg).Text;
                Console.WriteLine("Title provided on Flipkart's Customer Care Page =" + val1);

                string org = "Help Centre";
                Assert.AreEqual(val1, org);

                Console.WriteLine("Title of  Customer Care Page matched  successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

                                                           // verify Advertise Section

        public void ValidateAdvertiseSection()
        {
            try
            {
                //IWebElement element1 = Hooks.driver.FindElement(MoreButton);

                IList<IWebElement> element1 = Hooks.driver.FindElements(MoreButton);
                int count = element1.Count;

                IWebElement buttons = element1[1];

                Actions action = new Actions(Hooks.driver);
                action.MoveToElement(buttons).Perform();

                Hooks.driver.FindElement(Advertise).Click();
                ExplicitWaiting.waitForTime(8000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void AdvertiseSectionPg()
        {
            try
            {
                string val1 = Hooks.driver.FindElement(AdvertisePg).Text;
                Console.WriteLine("Title provided on Flipkart's Advertise Page =" + val1);

                string org = "Login to your account";
                Assert.AreEqual(val1, org);

                Console.WriteLine("Title of  Advertise Page matched  successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

                                                             // verify DownloadApp Section

        public void ValidateDownloadAppSection()
        {
            try
            {
                //IWebElement element1 = Hooks.driver.FindElement(MoreButton);

                IList<IWebElement> element1 = Hooks.driver.FindElements(MoreButton);
                int count = element1.Count;

                IWebElement buttons = element1[1];

                Actions action = new Actions(Hooks.driver);
                action.MoveToElement(buttons).Perform();

                Hooks.driver.FindElement(DwnldApp).Click();
                ExplicitWaiting.waitForTime(8000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void DownloadAppPg()
        {
            try
            {
                string val1 = Hooks.driver.FindElement(DwnldAppPg).Text;

                string txt1 = Hooks.driver.FindElement(DwnldAppPg).Text;
                string str = txt1;
                char[] spearator = { '\n', '\r' };

                string[] strlist = str.Split(spearator);
                string WebText1 = strlist[0];
                string Text2 = strlist[2];
                string Text3 = strlist[0] + " " + strlist[2];


                Console.WriteLine("Title provided on Flipkart's Download Page =" + Text3);

                string org = "INDIA'S MOST POPULAR! SHOPPING APP";
                Assert.AreEqual(Text3, org);

                Console.WriteLine("Title of  Download Page matched  successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }


                                                                // verify Cart Section

        public void ValidateCartSection()
        {


            try
            {
                Hooks.driver.FindElement(Cart).Click();
                ExplicitWaiting.waitForTime(8000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void CartPage()
        {
            try
            {
                string val1 = Hooks.driver.FindElement(CartPg).Text;


                Console.WriteLine("Title provided on Flipkart's cart Page =" + val1);

                string org = "Flipkart";
                Assert.AreEqual(val1, org);

                Console.WriteLine("Title of  cart Page matched  successfully");
            }
             catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

    }
}
