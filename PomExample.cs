using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace PageObject
{
    class PomExample
    {
        private const string Element = "Initial";
        private const string Value = "Sanjeet";
   
        
        [SetUp]
        public void Iniltialize()
        {
            PropertiesCollection.Driver=new ChromeDriver(@"D:\SeleniumC#\drivers");
            PropertiesCollection.Driver.Manage().Window.Maximize();
            PropertiesCollection.Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
        }
        [Test]
        public void ExecuteTestCases()
        {
            SeleniumMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);
            SeleniumMethods.EnterText(Element, Value, PropertyType.Name);
            Console.WriteLine("The Vlaue from my Tiltle is :" + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));
            Console.WriteLine("The Vlaue from my Tiltle is :" + SeleniumGetMethods.GetText("Initial", PropertyType.Name));
            SeleniumMethods.Click("Save", PropertyType.Name);
        }

        [TearDown]
        public void TearDown()
        {
            PropertiesCollection.Driver.Close();
        }
    }
}
