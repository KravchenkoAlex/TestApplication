using NUnit.Framework;
using TestApplication.Common.PageObjects;

namespace TestApplication
{
	public class Test : BaseTest
	{
		private SearchField _searchField;

		[Test]
		public void AutotestTest()
		{
			driver.Navigate().GoToUrl("https://rozetka.com.ua");
			SearchField.FillSearchField("iphone");
		}

		private SearchField SearchField => _searchField ?? (_searchField = new SearchField(driver));
	}
}
