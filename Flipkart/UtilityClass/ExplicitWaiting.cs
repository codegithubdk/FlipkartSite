using Flipkart.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Flipkart.UtilityClass
{
    class ExplicitWaiting
    {

        //public static void waitForAnElement(string _elementIdentifier)
        //{
        //    try
        //    {
        //        var _waitvariable = new WebDriverWait(Hooks.driver, new TimeSpan(0, 0, 40));
        //        var element = _waitvariable.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(_elementIdentifier)));
        //    }
        //    catch (Exception _ex)
        //    {
        //        Exception _customException = new Exception("The expected element " + _elementIdentifier + " not found");
        //        throw _customException;
        //    }
        //}
        //public static void waitForAnElementUntilClickable(string _element)
        //{
        //    try
        //    {
        //        var _waitvariable = new WebDriverWait(Hooks.driver, new TimeSpan(0, 0, 40));
        //        var element = _waitvariable.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(_element)));
        //    }
        //    catch (Exception _ex)
        //    {
        //        Exception _customException = new Exception("The expected element " + _element + " not found");
        //        throw _customException;
        //    }
        //}
        public static void waitForTime(int _time)
        {
            Thread.Sleep(_time);
        }

        //public static void waitForDriverToLoad(int _time)
        //{
        //    try
        //    {
        //        var _waitvariable = new WebDriverWait(Hooks.driver, new TimeSpan(0, 0, 40));
        //        Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        //       // var element = _waitvariable.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.((By.XPath()));
        //    }
        //    catch (Exception _ex)
        //    {
        //        Exception _customException = new Exception("The expected element " + _element + " not found");
        //        throw _customException;
        //    }
        //}

    }
}
