Feature: Story3
 As an user,
 I would like to navigate to the Industry Endorsements page
 so that I can see the correct page displayed and see the innovation award image displayed


Scenario: View Endorsements page and see innovation award image shown
 Given I am on the GlassWallssolutions home page
 When I click the Endorsements menu item
 Then I should see the Endorsements page displayed correctly
 And I should see the innovation award image displayed correctly  