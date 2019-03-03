Feature: SpecFlowFeature1
	In order to update my profile 
	As a skill trader
	I want to add the languages that I know

@mytag
Scenario: Check if user could able to add a language 
	Given I clicked on the Language tab under Profile page
	When I add a new language
	Then that language should be displayed on my listings

Scenario: Check if user is able to login to the website
Given I entered the website name www.Skillswap.pro
When  I Click enter button
Then  The website is displayed

Scenario:Check if user is able to join as member in www.Skillswap.pro
Given I clicked on the Join tab
When I entered the fields for First name, Last name, Email address, password, confirm password and click on agree to terms and condition, then click the join button
Then : The user profile is created

Scenario:Check if the user is able to login with the Username and password
Given I launch browser and enter url
When I entered the username, password and click on login button
Then  My profile home page should be displayed

Scenario:Check if user is able to edit the name in the profile
Given click on edit name
When I entered my name and clicked on save button
Then My name is displayed on the profile section 

@Test1
Scenario:Check if user is able to add Languages in profile section
Given Click on languages and then click on “Add new”
When I entered the Language, level and clicked on “Add” button
Then The language is displayed

Scenario:Check if user is able to add skills 
Given Click on skills and then click on “Add new”
When I entered the skill, level and clicked on “Add” button
Then The skills is displayed 

Scenario:Check if user is able to add education
Given Click on education  and click on “Add new”
When I entered the College name, Selected the country of college, enter title, Degree and select the year of graduation and clicked on “Add” button
Then The education is displayed

Scenario:Check if user is able to add Certification 
Given Click on certification and click on “Add new”
When I entered the name of certificate, certificate from and selected the year and clicked on “Add” button
Then The certification is displayed 

Scenario:Check if user is able to edit Languages
 Given I navigate to Profile and on Languages Tab Click on edit button 
And Edit the Language text box 
When I click Update button 
Then The language is updated 

@Test2
Scenario:Check if user is able to edit Skills
 Given I navigate to Profile and click Skills Tab and Click on edit button 
And Edit the Skill text box 
When I click Update button 
Then The skill is updated 

Scenario:Check if user is able to edit Education
 Given I navigate to Profile and click Education Tab and Click on edit button 
And Edit the Year in the Year dropdown 
When I click Update button 
Then The Education is updated 

Scenario:Check if user is able to edit Certifications
 Given I navigate to Profile and click Certifications Tab and Click on edit button 
And Edit the From textbox 
When I click Update button 
Then The Certification is updated 

Scenario:Check if user is able to edit and cancel on Education Tab
 Given I navigate to Profile and click Education Tab and Click on edit button 
When I click Cancel button 
Then The Education tab is displayed  

@Test3
Scenario:Check if user is able to delete Language
 Given I navigate to Profile and click Languages Tab 
When I click remove button 
Then The language is deleted 

Scenario:Check if user is able to delete Skills
 Given I navigate to Profile and click Skills Tab 
When I click remove button 
Then The skill is deleted 

Scenario:Check if user is able to delete Education
 Given I navigate to Profile and click Education Tab 
When I click remove button 
Then The education is deleted 

Scenario:Check if user is able to delete Certification
 Given I navigate to Profile and click Certifications Tab 
When I click remove button 
Then The certification is deleted 

Scenario:Check if user is able to edit and cancel on Languages Tab
 Given I navigate to Profile and click Languages Tab 
And : Click on edit button
When I click Cancel button 
Then The Languages tab is displayed  

Scenario:Check if user is able to edit and cancel on Skills Tab
 Given I navigate to Profile and click Skills Tab 
And : Click on edit button
When I click Cancel button 
Then The Skills tab is displayed  

Scenario:Check if user is able to edit and cancel on Certifications Tab
 Given Click Certifications Tab
And : Click on edit button
When I click Cancel button 
Then The Certification tab is displayed  

Scenario:Check if user is able to edit and Save description
 Given Click edit button on Description Tab 
When I enter details 
And Click Save button
Then The Description is added