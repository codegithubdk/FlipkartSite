using Flipkart.Common;
using Flipkart.UtilityClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipkart.CustomException
{
    class FlipkartException
    {
        Dashboard_Navbar obj = new Dashboard_Navbar();

        public static void WaitForAnElementVisible(string element)
        {
            try
            {
                var _waitvariable = new WebDriverWait(Hooks.driver, new TimeSpan(0, 0, 40));
                var ele = _waitvariable.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(element)));
            }
            catch (Exception _ex)
            {
                Exception _customException = new Exception("The expected element " + element + " not found");
                throw _customException;
            }
        }



        public static void WaitForAnElementUntilClickable(string _elements)
        {
            try
            {
                var _waitvariable = new WebDriverWait(Hooks.driver, new TimeSpan(0, 0, 40));
                var ele= _waitvariable.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(_elements)));
            }
            catch (Exception _ex)
            {
                Exception _customException = new Exception("The expected element " + _elements + " not found");
                throw _customException;
            }
        }



        public static void ElementNotSelectable(string element)
        {
            try
            {
                var _waitvariable = new WebDriverWait(Hooks.driver, new TimeSpan(0, 0, 40));
                 var ele = _waitvariable.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeSelected(By.XPath(element)));
            }
            catch (Exception _ex)
            {
                Exception _customException = new Exception("The expected element " + element + " not found");
                throw _customException;
            }
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Exceptional Case");
            //}
            //        } catch (TimeOutException e)
            //System.out.println(“WebDriver found that this element was not selectable.”);
            //    }
        }




        public static void NoSuchElementException(string element)
        {
            try
            {
                var _waitvariable = new WebDriverWait(Hooks.driver, new TimeSpan(0, 0, 40));
                var ele = _waitvariable.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath(element)));
            }
            catch (Exception _ex)
            {
                Exception _customException = new Exception("The expected element " + element + " not found");
                throw _customException;
            }
        }




        public static void TimeoutException(string element)
        {
            try
            {
                var _waitvariable = new WebDriverWait(Hooks.driver, new TimeSpan(0, 0, 40));
               // WebDriverWait wait = new WebDriverWait(Hooks.driver, TimeSpan.FromSeconds(10));
                var ele = _waitvariable.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(element)));
            }
            catch (Exception _ex)
            {
                Exception _customException = new Exception("The expected element " + element + " not found");
                throw _customException;
            }
        }



        public static void StaleElementReferenceException(string element)
        {
            try
            {
                // var _waitvariable = new WebDriverWait(Hooks.driver, new TimeSpan(0, 0, 40));

                // var ele = Hooks.driver.FindElement.StalenessOf(By.XPath(element)).sendKeys(values);
                var ele = Hooks.driver.FindElement(By.XPath(element));
            }
            catch (Exception _ex)
            {
                Exception _customException = new Exception("The expected element " + element + " not found");
                throw _customException;
            }
        }



        public static void WaitForDriver()
        {
            try
            {
                
                 //public static IWebDriver driver;
                  Hooks.driver = new ChromeDriver();
              
                
            }
            catch (Exception _ex)
            {
                Exception _customException = new Exception("driver not found");
                throw _customException;
            }
        }
       








    }
}
