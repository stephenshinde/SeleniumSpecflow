using DuckDuckgoTask.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DuckDuckgoTask.StepDefinations
{
    [Binding]
    public sealed class DuckDuckGoSearchSteps
    {

        [Given(@"I navigate to the Duckduckgo website")]
        public void GivenINavigateToTheDuckduckgoWebsite()
        {
            SearchHomePage searchhomePage = new SearchHomePage();
            // Verify Duckduckgo page title
            Assert.AreEqual("DuckDuckGo — Privacy, simplified.", searchhomePage.GetSearchHomePageTitle());
        }

        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string destination)
        {
            SearchHomePage searchhomePage = new SearchHomePage();
            // Enter destinationation in search field
            searchhomePage.EnterSearchKeyword(destination);
            // Click on Search button
            searchhomePage.ClickSearchBtn();

        }

        [Then(@"I should navigate on ""(.*)"" result page")]
        public void ThenIShouldNavigateOnResultPages(string CityName)
        {
            SearchResultPage searchResult = new SearchResultPage();
            // Wait untill page links presents
            searchResult.WaitUntillHeaderlinkPresent();
            // Verify page title with city name
            Assert.IsTrue(searchResult.GetSearchResultPageTitle().Contains(CityName));
            
        }


        [Then(@"I should get Bahamas keyword in all page link")]
        public void ThenIShouldGetBahamasKeywordInAllPageLink()
        {
            SearchResultPage searchResult = new SearchResultPage();
            for (int i = 0; i < searchResult.GetHeaderlinkCount(); i++)
            {
                // Get text of the each available links
                String CityHeaderName = searchResult.GetelementsText(i);
                Console.WriteLine(CityHeaderName);
                //Verify search result link contains city Name Bahamas
                Assert.IsTrue(CityHeaderName.Contains("Bahamas", StringComparison.OrdinalIgnoreCase));

            }
        }

        [Then(@"I should get Amsterdam keyword in all page link")]
        public void ThenIShouldGetAmsterdamKeywordInAllPageLink()
        {
            SearchResultPage searchResult = new SearchResultPage();
            for (int i = 0; i < searchResult.GetAmsterdamHeaderlinkCount(); i++)
            {
                // Get text of the each available links
                String CityHeaderName = searchResult.GetAmsterdamelementsText(i);
                Console.WriteLine(CityHeaderName);
                //Verify search result link contains city Name Amsterdam
                Assert.IsTrue(CityHeaderName.Contains("Amsterdam", StringComparison.OrdinalIgnoreCase));

            }
        }


    }
}
