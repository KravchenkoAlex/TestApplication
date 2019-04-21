using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestApplication.Common.PageObjects
{
	public class MainPage : PageObject
	{
		public MainPage(IWebDriver driver) : base(driver) { }

		[FindsBy(How = How.Name, Using = "search")]
		private IWebElement _searchField { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Найти')]")]
		private IWebElement _searchButton { get; set; }

		[FindsBy(How = How.XPath, Using = @"//ul[@class = 'suggest-list']/li[@data-name = '{0}']")]
		private IWebElement _dropdownProduct { get; set; }
		
		public void FillSearchField(string searchTerm)
		{
			_searchField.SendKeys(searchTerm);
		}

		public void SelectProductFromDropDown(string searchTerm)
		{
			string.Format(_dropdownProduct.Text, searchTerm);
			_dropdownProduct.Click();
		}
	}
}
