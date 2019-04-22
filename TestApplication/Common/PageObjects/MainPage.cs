using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestApplication.Common.Extensions;

namespace TestApplication.Common.PageObjects
{
	public class MainPage : PageObject
	{
		public MainPage(IWebDriver driver) : base(driver) { }

		[FindsBy(How = How.Name, Using = "search")]
		private IWebElement _searchField { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Найти')]")]
		private IWebElement _searchButton { get; set; }

		private IWebElement FindProductByTerm(string product)
		{
			return driver.FindElement(By.XPath($"//ul[@class = 'suggest-list']/li[@data-name = '{product}']"));
		}

		public MainPage FillSearchField(string searchTerm)
		{
			_searchField.SendKeys(searchTerm);
			return this;
		}

		public SearchPage SelectDropdownProduct(string searchTerm)
		{
			driver.WaitForElementToBeClickable(By.XPath("//ul[@class = 'suggest-list']"));
			FindProductByTerm(searchTerm).Click();
			return  new SearchPage(driver);
		}
	}
}
