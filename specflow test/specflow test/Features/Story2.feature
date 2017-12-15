Feature: Story2
 As an user,
 I would like to click the news menu item
 so that I can see the latest news section


Scenario: View News page
 Given I am on the GlassWallssolutions home page
 When I click the news menu item
 Then I should see the news page displayed correctly
 And the page title should contain "in the News"
