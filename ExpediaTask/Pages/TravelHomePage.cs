using CoreAutomation.Base;
using CoreAutomation.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ExpediaTask.Pages
{
    //Inherite baspage class to get all methods
    public class TravelHomePage : BasePage
    {
        //Locators
        private IWebElement DestinationInput => "//button[contains(@data-stid,'location-field-destination-menu-trigger')]".FindByXpath();
        private IList<IWebElement> CityList => "//div[contains(@class,'truncate')]//span".FindBysXpath();
        private IWebElement AddFlightCheckbox => "//input[@id='add-flight-switch' and @value='false']".FindByXpath();  
        private IWebElement OriginInput => "//button[contains(@data-stid,'location-field-origin-menu-trigger')]".FindByXpath();
        private IWebElement TravelersLink => "//a[contains(@class,'uitk-link uitk-menu-trigger')]".FindByXpath();
        private IWebElement Travelersbtn => "//button[@data-testid='travelers-field-trigger']".FindByXpath();
        private IWebElement AdultCountTxt => "adult-input-0".FindByID();
        private IList<IWebElement> AddRemoveBtn => "//button[contains(@class,'uitk-button uitk-button-small uitk-flex-item uitk-step-input-button')]".FindBysXpath();
        private IWebElement ChildCountTxt => "//input[@id='child-input-0']".FindByXpath();
        private IWebElement ChildAgeDropdown => "child-age-input-0-0".FindByID();
        private IWebElement FinalRoomTravelersInfo => "//span[@class='uitk-button-subText']".FindByXpath();
        private IWebElement DoneBtn => "//button[contains(@data-testid,'guests-done-button')]".FindByXpath();
        private IWebElement MonthHeader => "(//h2[@class='uitk-date-picker-month-name uitk-type-medium'])[1]".FindByXpath();
        private IWebElement RightPagination => "(//button[@class='uitk-button uitk-button-small uitk-flex-item uitk-button-paging'])[2]".FindByXpath();
        private IList<IWebElement> Date => "button[class='uitk-date-picker-day uitk-new-date-picker-day']".FindBysSelector();
        private IWebElement CheckInDate => "d1-btn".FindByID();
        private IWebElement CalendarDone => "//button[@data-stid='apply-date-picker']".FindByXpath();
        private IWebElement SearchBtn => "//button[@data-testid='submit-button']".FindByXpath();

        //Retur Home Page title
        public string GetExpediaHomePageTitle()
        {
            return GetPagetitle();
        }

        // Enter Goining Destination
        public void EnterGoingDestination(string Keyword, string CityName)
        {
            SendText(DestinationInput, Keyword);
            SelectCityFromDropdown(CityName);
           
        }

        private void WaittoloadAddFlightCHeckboxElementClickable()
        {
            WaitHelper.WaituntillElementtoBeClickable("(//span[@class='uitk-flex-item uitk-flex-shrink-0 uitk-switch-control'])[1]", 30);
        }
        // Click on Add FLight CHeckbox
        public void ClickAddFlightChecbox()
        {
            WaittoloadAddFlightCHeckboxElementClickable();
            ClickButton(AddFlightCheckbox);
        }

        // Enter leaving location and select value from drop down
        public void EnterLeavingDestination(string Keyword, string CityName)
        {
            SendText(OriginInput, Keyword);
            SelectCityFromDropdown(CityName);
            
        }
        // customize method to select city name from dropdown list
        private void SelectCityFromDropdown(string CityName)
        {
            Thread.Sleep(2000);
            foreach (var CList in CityList)
            {
                if (CList.Text.Equals(CityName))
                {
                    ClickButton(CList);
                }

            }
        }
        // Click on add travelers info some time it gets link or some itime it gets field to add travelers
       
        public void ClickonTravelersInfo()
        {
            // Added both condition in if else
            try
            {
              
                if (WebElementHelper.IsElementDisplayed(TravelersLink))
                {
                    ClickButton(TravelersLink);
                }
                else
                {
                    ClickButton(TravelersLink);
                }
            }
            catch (Exception)
            {
                ClickButton(Travelersbtn);

             
            }
             
        }
        // Click on decreased adult passenger
        public void DecreasedAdultCount()
        {
            ClickButton(AddRemoveBtn.ElementAt(0));
        }
        //method to get value of adult number
        public string GetAdultNumberText()
        {
            return AdultCountTxt.GetAttribute("value");
        }
        // Click on Add Child
        public void IncreaseChildCount()
        {
            ClickButton(AddRemoveBtn.ElementAt(3));
        }

        //method to get value of child number
        public string GetChildNumberText()
        {
            return ChildCountTxt.GetAttribute("value");
        }
        // Method to select child age
        public void SelectChildAge(string value)
        {
            SelectbyValue(ChildAgeDropdown , value);
        }
        // Method to get all added travelers info
        public string GetRoomTravelersInfo()
        {
           return GetTextName(FinalRoomTravelersInfo);
        }
        // Click on add travellers done button
        public void ClickTravelerDoneButton()
        {
            ClickButton(DoneBtn);
        }
        // method to click search button
        public void ClickSearchbtn()
        {
            ClickButton(SearchBtn);
        }

        public void SelectMonthFromCalendar(string ExpectedMonth)
        {
            while (!MonthHeader.Text.Contains(ExpectedMonth))
            {
                RightPagination.Click();
            }
        }

        //Method to select date from the calendar
        public void SelectDateFromCalendar(string ExpectedDate)
        {
         
            for (int i = 0; i < Date.Count; i++)
            {
                string text = Date.ElementAt(i).GetAttribute("data-day");
                if (text.Equals(ExpectedDate))
                {
                    Date.ElementAt(i).Click();
                    break;
                }


            }
        }

        //CLick on Check In button field
        public void ClickCheckInDate()
        {
            CheckInDate.Click();

        }

        // Click on Calendar DOne button
        public void ClickCalendarDone()
        {
            CalendarDone.Click();
        }

    }
     
}
