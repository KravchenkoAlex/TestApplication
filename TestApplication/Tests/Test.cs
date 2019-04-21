using NUnit.Framework;
using TestApplication.Common.PageObjects;
using TestApplication.Common.Support.Constants;

namespace TestApplication
{
	public class Test : BaseTest
	{
		private MainPage _mainPage;
		private SearchPage _searchPage;
		private ProductPage _productPage;

		[Test]
		public void AutotestTest()
		{
			driver.Navigate().GoToUrl("https://rozetka.com.ua");
			MainPage.FillSearchField("iphone");
			MainPage.SelectDropdownProduct("iphone se");
			SearchPage.SelectRandomProductWithColor(Color.Pink);
			ProductPage.SelectColor(Color.Silver);
		}

		private MainPage MainPage => _mainPage ?? (_mainPage = new MainPage(driver));
		private SearchPage SearchPage => _searchPage ?? (_searchPage = new SearchPage(driver));
		private ProductPage ProductPage => _productPage ?? (_productPage = new ProductPage(driver));
	}
}
