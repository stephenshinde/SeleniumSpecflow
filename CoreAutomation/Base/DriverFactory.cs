using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAutomation.Base
{
    public class DriverFactory
    {
        // Initialize Webdriver
        private static IWebDriver _driver;

        public static IWebDriver WebDriver
        {
            get
            {
                return _driver;
            }

            set
            {
                _driver = value;
            }
        }
    }
}
