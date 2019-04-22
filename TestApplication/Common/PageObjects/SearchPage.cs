using OpenQA.Selenium;
using System;

namespace TestApplication.Common.PageObjects
{
	public class SearchPage : PageObject
	{
		public SearchPage(IWebDriver driver) : base(driver) { }

		public int GetProductsCountWithColor(string color)
		{
			int elementsCount = driver.FindElements(By.XPath($"//*[@style = 'background-color: {color}']")).Count;
			return elementsCount;
		}

		public int GetUnavailableProductsCountWithColor(string color)
		{
			int unavailableElementsCount = driver
				.FindElements(By.XPath($"//a[@style = 'background-color: {color}']/ancestor::div[@class='g-i-tile-i-variants']/following-sibling::div/div/following-sibling::div[contains(text(), 'Снят')]")).Count;
			return unavailableElementsCount;
		}
		
		public ProductPage SelectRandomProductWithColor(string color)
		{
			int i = new Random().Next(1, GetProductsCountWithColor(color) - GetUnavailableProductsCountWithColor(color));
			driver.FindElement(By.XPath($"(//a[@style = 'background-color: {color}']//ancestor::div[@data-view_type='catalog_with_hover'])[{i}]")).Click();
			return new ProductPage(driver);
		}
	}
}