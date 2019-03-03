using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class SpecFlowFeature1Steps : Utils.Start
    {
        [Given(@"I launch browser and enter url")]
        public void GivenILaunchBrowserAndEnterUrl()
        {
           // SpecflowPages.Driver.Initialize();
          //  SpecflowPages.Utils.LoginPage.LoginStep();
        }
        [When(@"I entered the username, password and click on login button")]
        public void WhenIEnteredTheUsernamePasswordAndClickOnLoginButton()
        {
        }

        [Then(@"My profile home page should be displayed")]
        public void ThenMyProfileHomePageShouldBeDisplayed()
        {
            SpecflowPages.Utils.LoginPage.VerifyHomePage();
        }
        [Given(@"Click on languages and then click on “Add new”")]
        public void GivenClickOnLanguagesAndThenClickOnAddNew()
        {
            SpecflowPages.Utils.LanguagesPage.AddNewLanguage();

        }
        [When(@"I entered the Language, level and clicked on “Add” button")]
        public void WhenIEnteredTheLanguageLevelAndClickedOnAddButton()
        {
            SpecflowPages.Utils.LanguagesPage.AddLanguage();
        }

        [Then(@"The language is displayed")]
        public void ThenTheLanguageIsDisplayed()
        {
            SpecflowPages.Utils.LanguagesPage.VerifyLanguage();
        }

        [Given(@"I navigate to Profile and click Skills Tab and Click on edit button")]
        public void GivenINavigateToProfileAndClickSkillsTabAndClickOnEditButton()
        {
            SpecflowPages.Utils.SkillsPage.ClickEditSkill();
        }
        [Given(@"Edit the Skill text box")]
        public void GivenEditTheSkillTextBox()
        {
            SpecflowPages.Utils.SkillsPage.EditSkill();
        }
        [When(@"I click Update button")]
        public void WhenIClickUpdateButton()
        {
            SpecflowPages.Utils.SkillsPage.ClickUpdate();
        }
        [Then(@"The skill is updated")]
        public void ThenTheSkillIsUpdated()
        {
            Thread.Sleep(1000);
            SpecflowPages.Utils.SkillsPage.VerifySkillsUpdated();
        }
       
        [Given(@"I navigate to Profile and click Languages Tab")]
        public void GivenINavigateToProfileAndClickLanguagesTab()
        {
            SpecflowPages.Utils.LanguagesPage.ClickTab();

        }

        [When(@"I click remove button")]
        public void WhenIClickRemoveButton()
        {
            SpecflowPages.Utils.LanguagesPage.RemoveLanguage();
        }

        [Then(@"The language is deleted")]
        public void ThenTheLanguageIsDeleted()
        {
            SpecflowPages.Utils.LanguagesPage.Removed();
        }

        /*[Given(@"I clicked on the Language tab under Profile page")]
        public void GivenIClickedOnTheLanguageTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);
       
            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();

            
        }
        
        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {
            //Click on Add New button
            Driver.dri ver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

            //Add Language
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys("English");

            //Click on Language Level
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")).Click();

            //Choose the language level
            IWebElement Lang = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option"))[1];
            Lang.Click();

            //Click on Add button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();

        }

        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "English";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if(ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch(Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed",e.Message);
            }

        }*/
    }
}
