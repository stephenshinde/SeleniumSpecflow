using CoreAutomation.Base;
using CoreAutomation.Helpers;
using OpenQA.Selenium;

namespace DuckDuckgoTask.Pages
{
    public class SearchHomePage : BasePage
    {
        //locators with assigned name
        private IWebElement SearchInput => "//input[@id='search_form_input_homepage']".FindByXpath();
        private IWebElement SearchBtn => "//input[@id='search_button_homepage']".FindByXpath();

        //  Method returns search page title in string
        public string GetSearchHomePageTitle()
        {
            return GetPagetitle();
        }
        // Method for entering destination keyword in search field
        public void EnterSearchKeyword(string value)
        {
            SendText(SearchInput, value);
        }

        // Method for clicking on search button
        public void ClickSearchBtn()
        {
            ClickButton(SearchBtn);

        }
    }
}
