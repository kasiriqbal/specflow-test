using NUnit.Framework;
using OpenQA.Selenium;


namespace SpecflowTest
{
    class Endorsements : BasePage
    {
        
        public Endorsements(IWebDriver driver) : base(driver)
        {
        }

        public void EndorsementsPageShown()
        {
            Assert.IsTrue(WebBrowser.Current.PageSource.Contains("Glasswall has been recognised for its unique and patented security solution that delivers innovation to our customers"));
            Assert.IsTrue(WebBrowser.Current.PageSource.Contains("We are very proud to have been selected as winners in the industry events below:"));
            
        }

        public void CheckInnovationAwardImageShown()
        {
            Assert.IsTrue(WebBrowser.Current.PageSource.Contains("https://www.glasswallsolutions.com/wp-content/uploads/2016/10/IET-Award-logo-2016-Innovation-winner-415x100.jpg"));
            
        }
    }
}