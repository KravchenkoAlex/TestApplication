using NUnit.Framework;
using TestApplication.Common.PageObjects;
using TestApplication.Common.Support.Constants;
using TestApplication.Common.Utils;

namespace TestApplication
{
	public class Test : BaseTest
	{
		private MainPage _mainPage;
		private SearchPage _searchPage;
		private ProductPage _productPage;
		private CartPopup _cartPopup;
		private Navigation _navigation;
		
		string baseUrl = "https://rozetka.com.ua";

		[Test]
		[Description(@"
		Steps:
		1. Open Rozetka site
		2. Do search by 'iphone se' term
		3. Select any device with pink color
		4. Change color to 'Space Grey'
		5. Add product to cart
		Check:
			- Success title is displayed")]
		public void AddProductToCart()
		{
			#region TestData
			string serchTerm = "iphone";
			string serchDropdownTerm = "iphone se";
			#endregion

			Navigation.OpenSite(baseUrl);
			MainPage.FillSearchField(serchTerm)
				.SelectDropdownProduct(serchDropdownTerm);
			SearchPage.SelectRandomProductWithColor(Color.Pink);
			ProductPage.SelectColor(Color.SilverGrey);
			ProductPage.AddToCart();
			Assert.True(CartPopup.CheckProductIsAddedToCart(), "Title is displayed that product is added to cart");
		}

		private MainPage MainPage => _mainPage ?? (_mainPage = new MainPage(driver));
		private SearchPage SearchPage => _searchPage ?? (_searchPage = new SearchPage(driver));
		private ProductPage ProductPage => _productPage ?? (_productPage = new ProductPage(driver));
		private Navigation Navigation => _navigation ?? (_navigation = new Navigation(driver));
		private CartPopup CartPopup => _cartPopup ?? (_cartPopup = new CartPopup(driver));
	}
}
