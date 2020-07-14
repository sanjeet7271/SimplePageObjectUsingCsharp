using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        ClassName,
        ccsName
    }
    class PropertiesCollection
    {
        
        public static IWebDriver Driver { get; set; }
    }
}
