Feature: Story1
 As an user,
 I would like to click the management team menu item
 so that I can see the correct page displayed


Scenario: View Management team page
 Given I am on the GlassWallssolutions home page
 When I click the management team menu item
 Then I should see the management team page displayed correctly
 And the URL of the fierst image is present