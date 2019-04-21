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
			driver = new ChromeDriver(@"D:\TestProject\TestApplication\TestApplication\chromedriver");
		}

		[TearDown]
		protected void TearDown()
		{
			driver.Quit();
		}

    }
}
