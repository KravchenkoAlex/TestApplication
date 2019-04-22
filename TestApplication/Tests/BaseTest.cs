using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestApplication
{
	public class BaseTest
	{
		protected IWebDriver driver;

		[SetUp]
		protected void SetUp()
		{
			ChromeOptions options = new ChromeOptions();
			options.AddArgument("--start-maximized");
			driver = new ChromeDriver(options);
		}

		[TearDown]
		protected void TearDown()
		{
			driver.Quit();
		}
	}
}
