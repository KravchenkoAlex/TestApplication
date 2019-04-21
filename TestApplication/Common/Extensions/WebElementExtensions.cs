using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestApplication.Common.Extensions
{
	public static class WebElementExtensions
	{
		public static void WaitForElementToBeClickable(this IWebDriver driver, By by, Int32 timeOutInSeconds = 30)
		{
			var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
			wait.Until(ExpectedConditions.ElementToBeClickable(by));
		}
	}
}
