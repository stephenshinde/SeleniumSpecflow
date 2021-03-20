using CoreAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace CoreAutomation.Helpers
{
    //Extension Method
    public static class DriverExtension
    {
        //Extension method for Find By ID
        public static IWebElement FindByID(this string selector)
        {
            try
            {
                var element = DriverFactory.WebDriver.FindElement((By.Id(selector)));
                return element;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;

            }
        }
        //Extension method for Find By Xpath
        public static IWebElement FindByXpath(this string selector)
        {
            try
            {
                var element = DriverFactory.WebDriver.FindElement((By.XPath(selector)));
                return element;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;

            }
        }

        //Extension method for Find CSS Selector
        public static IWebElement FindBySelector(this string selector)
        {
            try
            {
                var element = DriverFactory.WebDriver.FindElement((By.CssSelector(selector)));
                return element;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;

            }
        }

        //Extension method for Find Bys Css Selector, return list of elements
        public static IList<IWebElement> FindBysSelector(this string selector)
        {
            try
            {
                var element = DriverFactory.WebDriver.FindElements((By.CssSelector(selector)));
                return element;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;

            }
        }

        //Extension method for Find Bys xpath, return list of elements
        public static IList<IWebElement> FindBysXpath(this string selector)
        {
            try
            {
                var element = DriverFactory.WebDriver.FindElements((By.XPath(selector)));
                return element;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;

            }
        }
    }
}
