using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestApplication.Common.PageObjects
{
	public class PageObject
	{
		protected IWebDriver driver;

		public PageObject(IWebDriver driver)
		{
			this.driver = driver;
			PageFactory.InitElements(driver, this);
		}
	}
}
