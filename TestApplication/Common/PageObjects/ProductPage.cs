using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestApplication.Common.Extensions;

namespace TestApplication.Common.PageObjects
{
	public class ProductPage : PageObject
	{
		public ProductPage(IWebDriver driver) : base(driver) { }

		private IWebElement FindColor(string color)
		{
			return driver.FindElement(By.XPath($"//span[@style='background-color: {color};']"));
		}

		public void SelectColor(string color)
		{
			driver.WaitForElementToBeClickable(By.XPath($"//span[@style='background-color: {color};']"));
			FindColor(color).Click();
		}
	}
}