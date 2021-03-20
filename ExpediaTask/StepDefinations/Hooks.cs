using CoreAutomation.Base;
using CoreAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ExpediaTask.StepDefinations
{
    [Binding]
    public sealed class Hooks
    {
        //Project Path
        public static string currentDir = Environment.CurrentDirectory;
        public static string[] Solutionpath = currentDir.Split("bin");
        readonly BaseTest BaseTestobject = new BaseTest();

   

       // Initialize test website before scenario
        [BeforeScenario]
        public void BeforeScenario()
        {
            BaseTestobject.InitializeTest("https://www.expedia.com/", Solutionpath[0] + @"Drivers\");
        }

        [AfterScenario]
        public void AfterScenario(ScenarioContext scenariocontext)
        {
            //Capture screenshot after scenario
            try
            {
                string title = scenariocontext.ScenarioInfo.Title;
                string Runname = title + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
                string artifactDirectory = Solutionpath[0] + @"TestScreenshot\";
                string screenshotFilePath = Path.Combine(Solutionpath[0] + @"TestScreenshot\", Runname + "_screenshot.png");
                UtilityHelper.CaptureScreenshot(screenshotFilePath);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error while taking screenshot" + ex);
            }
            //Close session
            BaseTestobject.TearDown();
        }


    }
}
