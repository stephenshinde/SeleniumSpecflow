using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CoreAutomation.Base
{
    public class BasePage
    {
		// Click method
		public void ClickButton(IWebElement element)
		{
			element.Click();
		}

		// SendKeys method
		public void SendText(IWebElement element, String value)
		{
			element.SendKeys(value);
		}

		// Clear text method
		public void ClearText(IWebElement element)
		{
			element.Clear();
		}

		// Return get text of the element
		public String GetTextName(IWebElement element)
		{
			return element.Text;
		}

		// Return current url
		public String GetCurrentUrl()
		{
			return DriverFactory.WebDriver.Url;
		}
		//Return page title
		public String GetPagetitle()
		{
			return DriverFactory.WebDriver.Title;
		}

		// Scroll to particular element
		public void MovetoElement(IWebElement element)
		{
			try
			{
				((IJavaScriptExecutor)DriverFactory.WebDriver).ExecuteScript("arguments[0].scrollIntoView();", element);
			}
			catch (NoSuchElementException e)
			{

				Console.WriteLine(e.Message);

			}
		}
		// Scroll to element if not displayed
		public void MovetoElementifNotDisplay(IWebElement element)
		{
			if (!element.Displayed)
			{
				try
				{
					((IJavaScriptExecutor)DriverFactory.WebDriver).ExecuteScript("arguments[0].scrollIntoView();", element);
				}
				catch (NoSuchElementException e)
				{
					Console.WriteLine(e.Message);

				}

			}
		}
		// Select dropdown by text
		public void SelectbyText(IWebElement element, String text)
		{
			SelectElement select = new SelectElement(element);
			select.SelectByText(text);
		}

		// Select dropdown by value
		public void SelectbyValue(IWebElement element, String value)
		{
			SelectElement select = new SelectElement(element);
			select.SelectByValue(value);
		}

		// select dropdown by index
		public void SelectbyIndex(IWebElement element, int index)
		{
			SelectElement select = new SelectElement(element);
			select.SelectByIndex(index);
		}
	}
}
