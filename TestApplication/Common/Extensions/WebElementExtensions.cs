using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace TestApplication.Common.Extensions
{
	public static class WebElementExtensions
	{
		public static void WaitForElementToBeClickable(this IWebDriver driver, IWebElement element, Int32 timeOutInSeconds = 15)
		{
			var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
		}

		public static void WaitForElementToBeClickable(this IWebDriver driver, By by, Int32 timeOutInSeconds = 30)
		{
			var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
		}

		public static void WaitForElementVisible(this IWebDriver driver, IWebElement element, Int32 timeOutInSeconds = 15)
		{

			for (int i = timeOutInSeconds * 10; i > 0; i--)
			{
				if (element.Displayed)
				{
					return;
				}
				Thread.Sleep(TimeSpan.FromMilliseconds(100));
			}
			throw new Exception($"Element {element} is not visible.");
		}

		public static void WaitForElementExists(this IWebDriver driver, By by, Int32 timeOutInSeconds = 15)
		{
			var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
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

		public static bool IsElementPresent(this IWebDriver driver, IWebElement element)
		{
			bool flag = false;
			try
			{
				flag = element.Displayed;
				return true;
			}
			catch
			{
				// ignored
			}
			return flag;

		}
	}
}
