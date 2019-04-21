using NUnit.Framework;
using TestApplication.Common.PageObjects;

namespace TestApplication
{
	public class Test : BaseTest
	{
		private MainPage _mainPage;

		[Test]
		public void AutotestTest()
		{
			driver.Navigate().GoToUrl("https://rozetka.com.ua");
			MainPage.FillSearchField("iphone");
		}

		private MainPage MainPage => _mainPage ?? (_mainPage = new MainPage(driver));
	}
}
