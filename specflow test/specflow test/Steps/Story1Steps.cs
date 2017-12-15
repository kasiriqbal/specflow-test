using SpecflowTest;
using System;
using TechTalk.SpecFlow;

namespace specflow_test
{
    [Binding]
    public class Story1Steps
    {
        [Given(@"I am on the GlassWallssolutions home page")]
        public void GivenIAmOnTheGlassWallssolutionsHomePage()
        {
            GlassWallsHomePage GWHP = new GlassWallsHomePage(WebBrowser.Current);
            GWHP.Navigate();
        }
        
        [When(@"I click the management team menu item")]
        public void WhenIClickTheManagementTeamMenuItem()
        {
            GlassWallsHomePage GWHP = new GlassWallsHomePage(WebBrowser.Current);
            GWHP.ClickMeetTheTeamMenuItem();
        }

        [Then(@"I should see the management team page displayed correctly")]
        public void ThenIShouldSeeTheManagementTeamPageDisplayedCorrectly()
        {
            MeetTheTeam mt = new MeetTheTeam(WebBrowser.Current);
            mt.MeetTheTeamPageShown();
        }

        [Then(@"the URL of the fierst image is present")]
        public void ThenTheURLOfTheFierstImageIsPresent()
        {
            MeetTheTeam mt = new MeetTheTeam(WebBrowser.Current);
            mt.CheckImageURL();
        }

        }
    }

