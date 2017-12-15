using System;
using OpenQA.Selenium;
namespace SpecflowTest
{
    class BasePage
    {
        private IWebDriver driver;
        private readonly string WebUrl;

        protected BasePage(IWebDriver driver, String loadUrl = "")
        {
            this.driver = WebBrowser.Current;
            WebUrl = loadUrl;
        }

        public void GoToSite()
        {
            driver.Navigate().GoToUrl(WebUrl);
        }
    }
}