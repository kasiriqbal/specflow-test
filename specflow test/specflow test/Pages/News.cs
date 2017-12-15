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

namespace SpecflowTest
{
    class News : BasePage
    {
        
        public News(IWebDriver driver) : base(driver)
        {
        }

        public void NewsPageShown()
        {
            Assert.IsTrue(WebBrowser.Current.PageSource.Contains("IN THE NEWS"));
        }

        public void CheckPageTitle()
        {
            string actualvalue = WebBrowser.Current.Title;
            Assert.True(actualvalue.Contains("in the News"));
        }
    }
}