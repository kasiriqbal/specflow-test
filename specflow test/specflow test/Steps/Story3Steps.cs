using SpecflowTest;
using System;
using TechTalk.SpecFlow;

namespace specflow_test
{
    [Binding]
    public class Story3Steps
    {
        [When(@"I click the Endorsements menu item")]
        public void WhenIClickTheEndorsementsMenuItem()
        {
            GlassWallsHomePage GWHP = new GlassWallsHomePage(WebBrowser.Current);
            GWHP.ClickEndorsementsMenuItem();
        }
        
        [Then(@"I should see the Endorsements page displayed correctly")]
        public void ThenIShouldSeeTheEndorsementsPageDisplayedCorrectly()
        {
            Endorsements End = new Endorsements(WebBrowser.Current);
            End.EndorsementsPageShown();
        }
        
        [Then(@"I should see the innovation award image displayed correctly")]
        public void ThenIShouldSeeTheInnovationAwardImageDisplayedCorrectly()
        {
            Endorsements End = new Endorsements(WebBrowser.Current);
            End.CheckInnovationAwardImageShown();
        }
    }
}
