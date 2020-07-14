using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace PageObject
{
    public class PageObjectExample
    {
        IWebDriver driver;

        [SetUp]
        public void Iniltialize()
        {
            driver = new ChromeDriver(@"D:\SeleniumC#\drivers");
         
        }
        [Test]
        public void ExecuteTestCases()
        {

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");

        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
