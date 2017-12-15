using OpenQA.Selenium;
using SpecflowTest;
using System;
using TechTalk.SpecFlow;

namespace specflow_test
{
    [Binding]
    public class Story2Steps
    {

        [When(@"I click the news menu item")]
        public void WhenIClickTheNewsMenuItem()
        {
            WebBrowser.Current.FindElement(By.CssSelector("#menu-item-115 > a > span")).Click();            
        }

        [Then(@"I should see the news page displayed correctly")]
        public void ThenIShouldSeeTheNewsPageDisplayedCorrectly()
        {
            News NP = new News(WebBrowser.Current);
            NP.NewsPageShown();
        }

        [Then(@"the page title should contain ""(.*)""")]
        public void ThenThePageTitleShouldContain(string p0)
        {
            News NP = new News(WebBrowser.Current);
            NP.CheckPageTitle();
        }


        }

        
    }



