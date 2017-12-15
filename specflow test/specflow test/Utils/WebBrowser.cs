using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace SpecflowTest
{
    [Binding]
    public class WebBrowser
    {
        public static IWebDriver Current
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey("browser"))
                {

                    ScenarioContext.Current["browser"] = new ChromeDriver();
                    Current.Manage().Window.Maximize();

                }
                return (IWebDriver)ScenarioContext.Current["browser"];
            }
        }

        [AfterFeature]
        public static void Close()
        {
            if (ScenarioContext.Current.ContainsKey("browser"))
            {
                Current.Dispose();
            }
        }
    }
}