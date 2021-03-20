using CoreAutomation.Base;
using OpenQA.Selenium;

namespace CoreAutomation.Helpers
{
     public  class UtilityHelper
    {
        //Capture screenshot method
        public static void CaptureScreenshot(string screenshotFilePath)
        {
            var screenshot = ((ITakesScreenshot)DriverFactory.WebDriver).GetScreenshot();
            // save screenshot
            screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);

        }

       

        
    }
}
