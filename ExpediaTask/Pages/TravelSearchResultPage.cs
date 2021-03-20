using CoreAutomation.Base;
using CoreAutomation.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpediaTask.Pages
{
    public class TravelSearchResultPage : BasePage
    {
        //Locator
        private IList<IWebElement> NYCityList => "//div[@data-test-id='content-hotel-neighborhood' and contains(text(),'New York')]".FindBysXpath();
       
        // Get count of city name contain Newyork in the result page
        public int GetCityNameCount()
        {
            return NYCityList.Count;
        }
        // Get City Name New York in Result string
        public String GetNYText(int index)
        {
            return NYCityList.ElementAt(index).Text;
        }
        //Wait to load element
        public void WaittoLoadCityElement()
        {
            WaitHelper.WaituntillElementVisibleByXpath("//div[@data-test-id='content-hotel-neighborhood' and contains(text(),'New York')]", 60);
        }
    }
}
