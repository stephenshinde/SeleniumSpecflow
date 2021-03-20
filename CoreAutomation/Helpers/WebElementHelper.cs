using OpenQA.Selenium;
using System;

namespace CoreAutomation.Helpers
{
    public static class WebElementHelper
    {
        // Is element display method
        public static bool IsElementDisplayed(IWebElement element)
        {
            try
            {
                bool ele = element.Displayed;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Is element enabled method
        public static bool IsElementEnabled(IWebElement element)
        {
            try
            {
                bool ele = element.Displayed;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Is element selected method
        public static bool IsElementSelected(IWebElement element)
        {
            try
            {
                bool ele = element.Selected;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
