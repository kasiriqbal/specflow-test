using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using SpecflowTest;
using OpenQA.Selenium.Interactions;

namespace SpecflowTest
{
    class GlassWallsHomePage
    {
        private IWebDriver driver;

        public GlassWallsHomePage(IWebDriver driver)
        {
            this.driver = WebBrowser.Current;
        }

        public void Navigate()
        {
            WebBrowser.Current.Navigate().GoToUrl("https://www.glasswallsolutions.com/");
            string actualvalue = WebBrowser.Current.Title;
            Assert.True(actualvalue.Contains("Email Attachment Security"));
        }

        public void ClickMeetTheTeamMenuItem()
        {
            HoveroverCompanyMenu();
            WebBrowser.Current.FindElement(By.CssSelector("#menu-item-5718 > a > span")).Click();

        }

        public void ClickEndorsementsMenuItem()
        {
            HoveroverCompanyMenu();
            WebBrowser.Current.FindElement(By.CssSelector("#menu-item-5866 > a > span")).Click();
        }

        private void HoveroverCompanyMenu()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#menu-item-4817 > a > span")));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(1000);
        }
    }
}