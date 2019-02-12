using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDDTesting
{
    [Binding]
    public sealed class Hooks1
    {
        public static IWebDriver Driver; //WebDriver object

        [BeforeScenario]
        public static void GetChromeDriver()
        {
            Driver = new ChromeDriver();
        }

    }
}
