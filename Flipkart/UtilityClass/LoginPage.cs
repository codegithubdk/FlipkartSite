using Flipkart.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipkart.UtilityClass
{
    public class LoginPage : BasePageImplementation
    {


        //public LoginPage(IWebDriver driver) : base(driver)
        //{

        //}

         By Pswrd = By.XPath("//input[@class='_2IX_2- _3mctLh VJZDxU']");
         By email = By.XPath("//input[@class='_2IX_2- VJZDxU']");
         By logIn1 = By.XPath("//button[@class='_2KpZ6l _2HKlqd _3AWRsL']");
         By phn = By.XPath("//input[@class='_2IX_2- VJZDxU']");
         By contin = By.XPath("//span[normalize-space()='CONTINUE']");
         By pass2 = By.XPath("//input[@type='password']");
         By loginn = By.XPath("//button[@type='submit']//span[contains(text(),'Login')]");
         By lgout = By.XPath("//div[normalize-space()='Logout']");
         By usrname = By.XPath("//div[contains(text(), 'Deepika')]");

        //public IWebElement getUsername()
        //{
        //    return getElement(usrname);
        //}
        //public void clickUsername()
        //{
        //    getUsername().Click();
        //}
        public void GetIdPass(string Email, string Password)
        {
           
            
                Hooks.driver.FindElement(email).SendKeys(Email);
                ExplicitWaiting.waitForTime(2000);
                Hooks.driver.FindElement(Pswrd).SendKeys(Password);
                ExplicitWaiting.waitForTime(2000);
           

            
        }


        public void ClickLogin()
        {
           
                Hooks.driver.FindElement(logIn1).Click();
                ExplicitWaiting.waitForTime(2000);
            
        }

        public void EnterPhoneAndClkContinue(string Phone)
        {
                Hooks.driver.FindElement(phn).SendKeys(Phone);
                Hooks.driver.FindElement(contin).Click();
                ExplicitWaiting.waitForTime(2000);
            
            
        }

        public void Password2(string Password)
        {
           
                Hooks.driver.FindElement(pass2).SendKeys(Password);
                ExplicitWaiting.waitForTime(2000);
           
           
        }

        public void FinalLogin()
        {
                Hooks.driver.FindElement(loginn).Click();
                ExplicitWaiting.waitForTime(2000);
           
        }

        public void Logout()
        {
            //IWebElement ele = Hooks.driver.FindElement(usrname);
            //Actions action = new Actions(Hooks.driver);
            //action.MoveToElement(ele).Perform();

            //// ExplicitWaiting.waitForTime(2000);
            //Hooks.driver.FindElement(lgout).Click();
            //Console.WriteLine(" logout done");

            try
            {
                IWebElement ele = Hooks.driver.FindElement(usrname);
                Actions action = new Actions(Hooks.driver);
                action.MoveToElement(ele).Perform();

                // ExplicitWaiting.waitForTime(2000);
                Hooks.driver.FindElement(lgout).Click();
                Console.WriteLine(" logout done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }


        }

        public void Uptologin(string Email, string Password, string Phone)
        {
           
            
                GetIdPass(Email, Password);
                ClickLogin();
                EnterPhoneAndClkContinue(Phone);
                Password2(Password);
                FinalLogin();

                ExplicitWaiting.waitForTime(2000);
            


        }








    }
}
