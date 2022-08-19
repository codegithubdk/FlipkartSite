using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipkart.Common
{
    public class BasePageImplementation : BasePage
    {

        //cinst. 2
        //public BasePageImplementation(IWebDriver driver) : base(driver)
        //{

        //}


        public override IWebElement getElement(By Locators)
        {
            IWebElement element = null;
            try
            {
                element = Hooks.driver.FindElement(Locators);
                return element;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);

            }
            return element;

        }


        public override string getPageTitle()
        {
            return Hooks.driver.Title;

        }


        public override IWebElement waitForElementPresent(By Locators)
        {
            IWebElement element = null;
            try
            {

                var _waitvariable = new WebDriverWait(Hooks.driver, new TimeSpan(0, 0, 40));
                element = _waitvariable.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(Locators));
                return element;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);

            }
            return element;
        }


        public override void waitForPageTitle(string title)
        {
            bool element1 = false;
            try
            {
                var _waitvariable1 = new WebDriverWait(Hooks.driver, new TimeSpan(0, 0, 40));
                element1 = _waitvariable1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TitleContains("abs"));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }
    }
}
