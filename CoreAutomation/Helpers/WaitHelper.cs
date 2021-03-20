using CoreAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CoreAutomation.Helpers
{
    public class WaitHelper
    {
        // Wait function unill element visible
        public static void WaituntillElementVisibleByXpath(string LocatorName, double Explicitwait)
        {
            WebDriverWait wait = new WebDriverWait(DriverFactory.WebDriver, TimeSpan.FromSeconds(Explicitwait));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(LocatorName)));
        }

        // Wait function untill text present in element
        public static void WaituntillTextToBePresentInElement(IWebElement element, string text ,double Explicitwait)
        {
            WebDriverWait wait = new WebDriverWait(DriverFactory.WebDriver, TimeSpan.FromSeconds(Explicitwait));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(element , text));
        }
        //Wait untill Element to be clickable
        public static void WaituntillElementtoBeClickable(string LocatorName, double Explicitwait)
        {
            WebDriverWait wait = new WebDriverWait(DriverFactory.WebDriver, TimeSpan.FromSeconds(Explicitwait));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(LocatorName)));
        }
    }
}
