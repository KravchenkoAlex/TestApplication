using OpenQA.Selenium;

namespace TestApplication.Common.Utils
{
	public class Navigation
	{
		protected readonly IWebDriver driver;

		public Navigation(IWebDriver driver)
		{
			this.driver = driver;
			
		}

		public void OpenSite(string baseUrl)
		{
			driver.Navigate().GoToUrl(baseUrl);
		}
	}
}
