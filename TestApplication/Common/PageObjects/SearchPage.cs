using OpenQA.Selenium;
using System;

namespace TestApplication.Common.PageObjects
{
	public class SearchPage : PageObject
	{
		public SearchPage(IWebDriver driver) : base(driver) { }

		public int GetProductsCountWithColor (string color)
		{
			int elementsCount = driver.FindElements(By.XPath($"//*[@style = 'background-color: {color}']")).Count;
			return elementsCount;
		}

		public void SelectRandomProductWithColor(string color)
		{
			Random random = new Random();
			int i = random.Next(1, GetProductsCountWithColor(color));
			driver.FindElement(By.XPath($"(//a[@style = 'background-color: {color}']//ancestor::div[@data-view_type='catalog_with_hover'])[{i}]")).Click();
		}
	}
}