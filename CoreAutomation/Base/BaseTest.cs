using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAutomation.Base
{
    public class BaseTest
    {
        // Function for Initiazlize test method 
        public void InitializeTest(string url , string driverPath)
        {
            DriverFactory.WebDriver = new ChromeDriver(driverPath);
            DriverFactory.WebDriver.Url = url;
            DriverFactory.WebDriver.Manage().Window.Maximize();
            DriverFactory.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        // Function for quite driver
        public void TearDown()
        {
            DriverFactory.WebDriver.Quit();
        }
    }
}

