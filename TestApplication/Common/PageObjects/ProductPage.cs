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

		public ProductPage SelectColor(string color)
		{
			driver.WaitForElementToBeClickable(Color(color));
			if (! driver.IsElementPresent(By.XPath($"//span[@style='background-color: {color};']/rz-svg-sprite[@classname='variants-i-icon-active']")))
			{
				Color(color).Click();
			}
			return this;
		}

		public CartPopup AddToCart()
		{
			if(!driver.IsElementPresent(_addToCartBtn))
			{
				throw new Exception($"Element {_addToCartBtn} is not available, Please relaunch test.");
			}
			_addToCartBtn.Click();
			return new CartPopup(driver);
		}
	}
}