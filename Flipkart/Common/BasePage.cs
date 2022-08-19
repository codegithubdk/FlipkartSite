using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipkart.Common
{
    public abstract class BasePage
    {
        //public IWebDriver driver;
        //public WebDriverWait Wait;



        //const.1
        //public BasePage(IWebDriver driver)
        //{
        //    this.driver = driver;
        //    this.Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //}


        public abstract string getPageTitle();


        public abstract IWebElement getElement(By Locators);


        //public abstract string get();

        public abstract IWebElement waitForElementPresent(By Locators);



        public abstract void waitForPageTitle(string title);
    }

}
