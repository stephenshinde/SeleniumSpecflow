using CoreAutomation.Base;
using CoreAutomation.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckDuckgoTask.Pages
{
    public class SearchResultPage : BasePage
    {
        //Locators
        private IList<IWebElement> HeaderLinkTitle => "//a[@class='result__a']".FindBysXpath();
        private IList<IWebElement> AmsterdamHeaderLinkTitle => "//h2[contains(.,'Amsterdam')  or contains(.,'amsterdam')]".FindBysXpath();



        //  Method to returns search result page title in string
        public string GetSearchResultPageTitle()
        {
            return GetPagetitle();
        }

        //  Method to returns link title in integer
        public int GetHeaderlinkCount()
        {
            return HeaderLinkTitle.Count;
        }

        // Method to returns text of the header links
        public String GetelementsText(int index)
        {
            return HeaderLinkTitle.ElementAt(index).Text;
        }

        //Get the link counts which contains Amsterdam in the link
        public int GetAmsterdamHeaderlinkCount()
        {
            return AmsterdamHeaderLinkTitle.Count;
        }

        // Method to returns Amsterdam text in the header links
        public String GetAmsterdamelementsText(int index)
        {
            return AmsterdamHeaderLinkTitle.ElementAt(index).Text;
        }
        // Wait method to present all links in result page
        public void WaitUntillHeaderlinkPresent()
        {
            WaitHelper.WaituntillElementVisibleByXpath("//a[@class='result__a']", 60);
        }

    }
}
