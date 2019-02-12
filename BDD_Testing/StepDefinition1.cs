using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDDTesting
{
    [Binding]
    public sealed class StepDefinition1
    {
        IWebDriver driver = Hooks1.Driver;

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateToWww_Gmail_Com(string URL)
        {
            driver.Navigate().GoToUrl(URL);
        }


        [Given(@"I enter username ""(.*)""")]
        public void GivenIEnterUsername(string UserName)
        {
            driver.FindElement(By.Id("identifierId")).SendKeys(UserName);
        }



    }
}
