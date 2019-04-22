using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestApplication.Common.Extensions;

namespace TestApplication.Common.PageObjects
{
	public class CartPopup : PageObject
	{
		public CartPopup(IWebDriver driver) : base(driver) { }

		string cartPopupTitle = "//h2[contains(text(), 'Вы')]";

		[FindsBy(How = How.XPath, Using = "//h2[contains(text(), 'Вы')]")]
		private IWebElement _cartPopupTitle { get; set; }
		
		public bool CheckProductIsAddedToCart()
		{
			driver.WaitForElementExists(By.XPath(cartPopupTitle));
			return driver.IsElementPresent(_cartPopupTitle);
		}
	}
}
