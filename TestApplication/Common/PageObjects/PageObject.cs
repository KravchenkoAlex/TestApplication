using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestApplication.Common.PageObjects
{
	public class PageObject
	{
		protected readonly IWebDriver driver;

		public PageObject(IWebDriver driver)
		{
			this.driver = driver;
			PageFactory.InitElements(driver, this);
		}
	}
}
