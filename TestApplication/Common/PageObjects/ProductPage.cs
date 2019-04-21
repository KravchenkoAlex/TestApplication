using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using TestApplication.Common.Extensions;

namespace TestApplication.Common.PageObjects
{
	public class ProductPage : PageObject
	{
		public ProductPage(IWebDriver driver) : base(driver) { }
		
		[FindsBy(How = How.XPath, Using = "//div[contains(@class, 'toOrder')]//button[@type='submit']")]
		private IWebElement _addToCartBtn { get; set; }

		public IWebElement Color(string color)
		{
			return driver.FindElement(By.XPath($"//span[@style='background-color: {color};']"));
		}
		
		public IWebElement SelectedColor(string color)
		{
			return driver.FindElement(By.XPath($"//span[@style='background-color: {color};']/rz-svg-sprite[@classname='variants-i-icon-active']"));
		}

		public void SelectColor(string color)
		{
			driver.WaitForElementToBeClickable(By.XPath($"//span[@style='background-color: {color};']"));
			if (! driver.IsElementPresent(By.XPath($"//span[@style='background-color: {color};']/rz-svg-sprite[@classname='variants-i-icon-active']")))
			{
				Color(color).Click();
			}
		}

		public void AddToCart()
		{
			_addToCartBtn.Click();
		}
	}
}