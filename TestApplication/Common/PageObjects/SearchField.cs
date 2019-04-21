using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace TestApplication.Common.PageObjects
{
	class SearchField : PageObject
	{
		public SearchField(IWebDriver driver) : base(driver) { }

		[FindsBy(How = How.Name, Using = "search")]
		private IWebElement _searchField { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Найти')]")]
		private IWebElement _searchButton { get; set; }

		[FindsBy(How = How.XPath, Using = @"//ul[@class = 'suggest-list']/li[@data-name = '{searchTerm}']")]
		private IWebElement _dropdownProduct { get; set; }
		

		public SearchField FillSearchField(string searchTerm)
		{
			_searchField.SendKeys(searchTerm);
			return this;
		}

		//public void SelectProductFromDropDown(string searchTerm)
		//{
		//	_dropdownProduct(searchTerm).Click();
		//}
	}
}
