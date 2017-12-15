using NUnit.Framework;
using OpenQA.Selenium;


namespace SpecflowTest
{
    class MeetTheTeam : BasePage
    {
        
        public MeetTheTeam(IWebDriver driver) : base(driver)
        {
        }

        public void MeetTheTeamPageShown()
        {
            Assert.IsTrue(WebBrowser.Current.PageSource.Contains("Management Team"));
        }

        public void CheckImageURL()
        {
            Assert.IsTrue(WebBrowser.Current.PageSource.Contains("https://www.glasswallsolutions.com/wp-content/uploads/2016/10/Anne-Tiedemann.cropped-150x200.jpg"));
            
        }
    }
}