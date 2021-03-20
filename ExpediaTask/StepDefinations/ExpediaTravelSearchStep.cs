using ExpediaTask.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ExpediaTask.StepDefinations
{
    [Binding]
    public sealed class ExpediaTravelSearchStep
    {
        [Given(@"I navigate to the Expedia website")]
        public void GivenINavigateToTheExpediaWebsite()
        {
            // Verify Expedia Home Page Title
            TravelHomePage ThomePage = new TravelHomePage();
            Assert.AreEqual("Expedia Travel: Vacation Homes, Hotels, Car Rentals, Flights & More", ThomePage.GetExpediaHomePageTitle());
        }

        [When(@"I look for a flight\+accommodation from Brussels to New York")]
        public void WhenILookForAFlightAccommodationFromBrusselsToNewYork()
        {
            TravelHomePage ThomePage = new TravelHomePage();
            //Enter Destination New York in Going to field
            ThomePage.EnterGoingDestination("New", "New York");

            // Click on Check In Date
            ThomePage.ClickCheckInDate();

            // Select June 2021 as Month
            ThomePage.SelectMonthFromCalendar("June 2021");

            //Select Check In date is 2
            ThomePage.SelectDateFromCalendar("2");

            //Click on Calendar done button
            ThomePage.ClickCalendarDone();

            //Click on Travelers info link / field
            ThomePage.ClickonTravelersInfo();

            //Keep 1 adult in the field 
            ThomePage.DecreasedAdultCount();

            //Verify adult count as 1
            Assert.AreEqual("1", ThomePage.GetAdultNumberText());

            //Add 1 child in travel
            ThomePage.IncreaseChildCount();

            //Verify Child count as 1
            Assert.AreEqual("1", ThomePage.GetChildNumberText());

            //Add child age is 3 yers
            ThomePage.SelectChildAge("3");

            // Verify added travelrs data
            Assert.IsTrue(ThomePage.GetRoomTravelersInfo().Contains("2 travelers"));

            //Click on Travelers info Done button
            ThomePage.ClickTravelerDoneButton();

            // Click on Add flight Checkbox to add flight
            ThomePage.ClickAddFlightChecbox();

            //Enter Leaving to Destination Brussels
            ThomePage.EnterLeavingDestination("Bru", "Brussels (BRU - All Airports)");

            //Click on Search button
            ThomePage.ClickSearchbtn();
        }

        [Then(@"the result page contains travel option for the chosen destination")]
        public void ThenTheResultPageContainsTravelOptionForTheChosenDestination()
        {
            TravelSearchResultPage travelSearchResultPage = new TravelSearchResultPage();
            //Wait operation
            travelSearchResultPage.WaittoLoadCityElement();

            
            for (int i = 0; i < travelSearchResultPage.GetCityNameCount(); i++)
            {
                // Get Search result contains destionation name Ney work
                String HotelCityName = travelSearchResultPage.GetNYText(i);
                //and Verify it
                Assert.IsTrue(HotelCityName.Contains("New York", StringComparison.OrdinalIgnoreCase));

            }
        }


    }
}
