using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestApplication.Common.Extensions
{
	public static class WebElementExtensions
	{
		public static void WaitForElementToBeClickable(this IWebDriver driver, By by, Int32 timeOutInSeconds = 15)
		{
			var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
			wait.Until(ExpectedConditions.ElementToBeClickable(by));
		}

		public static bool IsElementPresent(this IWebDriver driver, By by)
		{
			try
			{
				driver.FindElement(by);
				return true;
			}
			catch (NoSuchElementException)
			{
				return false;
			}
		}
	}
}
