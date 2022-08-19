using Flipkart.Common;
using Flipkart.UtilityClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Flipkart.StepFiles
{
    [Binding]
    public class FlipkartLoginSteps : LoginPage
    {

        //public FlipkartLoginSteps(IWebDriver driver) : base(driver)
        //{

        //}

        LoginPage log = new LoginPage();

       

        [When(@"Enter Email(.*) and Password(.*)")]
        public void WhenEnterEmailAndPassword(string Email, string password)
        {
            // enterCredentials(email, password);
            log.GetIdPass(Email, password);
        }
        
        [When(@"Click on Login Button")]
        public void WhenClickOnLoginButton()
        {
            //clickLogin();
            log.ClickLogin();
        }


        [Then(@"New page should appear")]
        public void ThenNewPageShouldAppear()
        {
            Console.WriteLine("Redirected to new page");
        }

        [When(@"Enter the Phone Number (.*) and click on Continue button")]
        public void WhenEnterThePhoneNumberAndClickOnContinueButton(string Phone)
        {
            // verifyPhoneNumber(phone_no);
            log.EnterPhoneAndClkContinue(Phone);
        }


        [Then(@"Ask to ReEnter Password (.*)")]
        public void ThenAskToReEnterPassword(string Password)
        {
            //enterPassword(password);
            log.Password2(Password);
        }

        [When(@"Click on Login button after enter password")]
        public void WhenClickOnLoginButtonAfterEnterPassword()
        {
            // loginClick();
            log.FinalLogin();
        }
        
        [Then(@"Homepage should open")]
        public void ThenHomepageShouldOpen()
        {
            Console.WriteLine("Successfully logged in");
            ExplicitWaiting.waitForTime(2000);
            log.Logout();
        }
    }
}
