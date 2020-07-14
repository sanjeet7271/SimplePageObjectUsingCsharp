using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    class PageObjects
    {
        public PageObjects()
        {

        }
        [FindsBy(How=How.Id, Using = "TitleId")]
        public IWebElement DDTitleID { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement TxtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement BtnSave { get; set; }

    }
}
