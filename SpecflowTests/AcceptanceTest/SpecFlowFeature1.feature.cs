﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecflowTests.AcceptanceTest
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SpecFlowFeature1Feature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "SpecFlowFeature1.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SpecFlowFeature1", "\tIn order to update my profile \r\n\tAs a skill trader\r\n\tI want to add the languages" +
                    " that I know", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "SpecFlowFeature1")))
            {
                global::SpecflowTests.AcceptanceTest.SpecFlowFeature1Feature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user could able to add a language")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        public virtual void CheckIfUserCouldAbleToAddALanguage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user could able to add a language", null, new string[] {
                        "mytag"});
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 testRunner.Given("I clicked on the Language tab under Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I add a new language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("that language should be displayed on my listings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to login to the website")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfUserIsAbleToLoginToTheWebsite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to login to the website", null, ((string[])(null)));
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 13
testRunner.Given("I entered the website name www.Skillswap.pro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
testRunner.When("I Click enter button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
testRunner.Then("The website is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to join as member in www.Skillswap.pro")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfUserIsAbleToJoinAsMemberInWww_Skillswap_Pro()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to join as member in www.Skillswap.pro", null, ((string[])(null)));
#line 17
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 18
testRunner.Given("I clicked on the Join tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
testRunner.When("I entered the fields for First name, Last name, Email address, password, confirm " +
                    "password and click on agree to terms and condition, then click the join button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
testRunner.Then(": The user profile is created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if the user is able to login with the Username and password")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfTheUserIsAbleToLoginWithTheUsernameAndPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if the user is able to login with the Username and password", null, ((string[])(null)));
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 23
testRunner.Given("I launch browser and enter url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
testRunner.When("I entered the username, password and click on login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
testRunner.Then("My profile home page should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to edit the name in the profile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfUserIsAbleToEditTheNameInTheProfile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to edit the name in the profile", null, ((string[])(null)));
#line 27
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 28
testRunner.Given("click on edit name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
testRunner.When("I entered my name and clicked on save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
testRunner.Then("My name is displayed on the profile section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to add Languages in profile section")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Test1")]
        public virtual void CheckIfUserIsAbleToAddLanguagesInProfileSection()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to add Languages in profile section", null, new string[] {
                        "Test1"});
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 34
testRunner.Given("Click on languages and then click on “Add new”", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
testRunner.When("I entered the Language, level and clicked on “Add” button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
testRunner.Then("The language is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to add skills")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfUserIsAbleToAddSkills()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to add skills", null, ((string[])(null)));
#line 38
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 39
testRunner.Given("Click on skills and then click on “Add new”", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
testRunner.When("I entered the skill, level and clicked on “Add” button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
testRunner.Then("The skills is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to add education")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfUserIsAbleToAddEducation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to add education", null, ((string[])(null)));
#line 43
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 44
testRunner.Given("Click on education  and click on “Add new”", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
testRunner.When("I entered the College name, Selected the country of college, enter title, Degree " +
                    "and select the year of graduation and clicked on “Add” button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
testRunner.Then("The education is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to add Certification")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfUserIsAbleToAddCertification()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to add Certification", null, ((string[])(null)));
#line 48
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 49
testRunner.Given("Click on certification and click on “Add new”", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
testRunner.When("I entered the name of certificate, certificate from and selected the year and cli" +
                    "cked on “Add” button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
testRunner.Then("The certification is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to edit Languages")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfUserIsAbleToEditLanguages()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to edit Languages", null, ((string[])(null)));
#line 53
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 54
 testRunner.Given("I navigate to Profile and on Languages Tab Click on edit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 55
testRunner.And("Edit the Language text box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
testRunner.When("I click Update button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
testRunner.Then("The language is updated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to edit Skills")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Test2")]
        public virtual void CheckIfUserIsAbleToEditSkills()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to edit Skills", null, new string[] {
                        "Test2"});
#line 60
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 61
 testRunner.Given("I navigate to Profile and click Skills Tab and Click on edit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 62
testRunner.And("Edit the Skill text box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
testRunner.When("I click Update button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
testRunner.Then("The skill is updated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to edit Education")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfUserIsAbleToEditEducation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to edit Education", null, ((string[])(null)));
#line 66
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 67
 testRunner.Given("I navigate to Profile and click Education Tab and Click on edit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 68
testRunner.And("Edit the Year in the Year dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
testRunner.When("I click Update button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
testRunner.Then("The Education is updated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to edit Certifications")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfUserIsAbleToEditCertifications()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to edit Certifications", null, ((string[])(null)));
#line 72
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 73
 testRunner.Given("I navigate to Profile and click Certifications Tab and Click on edit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 74
testRunner.And("Edit the From textbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
testRunner.When("I click Update button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
testRunner.Then("The Certification is updated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to edit and cancel on Education Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfUserIsAbleToEditAndCancelOnEducationTab()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to edit and cancel on Education Tab", null, ((string[])(null)));
#line 78
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 79
 testRunner.Given("I navigate to Profile and click Education Tab and Click on edit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 80
testRunner.When("I click Cancel button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
testRunner.Then("The Education tab is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to delete Language")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Test3")]
        public virtual void CheckIfUserIsAbleToDeleteLanguage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to delete Language", null, new string[] {
                        "Test3"});
#line 84
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 85
 testRunner.Given("I navigate to Profile and click Languages Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 86
testRunner.When("I click remove button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
testRunner.Then("The language is deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to delete Skills")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfUserIsAbleToDeleteSkills()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to delete Skills", null, ((string[])(null)));
#line 89
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 90
 testRunner.Given("I navigate to Profile and click Skills Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 91
testRunner.When("I click remove button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
testRunner.Then("The skill is deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to delete Education")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfUserIsAbleToDeleteEducation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to delete Education", null, ((string[])(null)));
#line 94
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 95
 testRunner.Given("I navigate to Profile and click Education Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 96
testRunner.When("I click remove button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 97
testRunner.Then("The education is deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to delete Certification")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfUserIsAbleToDeleteCertification()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to delete Certification", null, ((string[])(null)));
#line 99
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 100
 testRunner.Given("I navigate to Profile and click Certifications Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 101
testRunner.When("I click remove button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 102
testRunner.Then("The certification is deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to edit and cancel on Languages Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfUserIsAbleToEditAndCancelOnLanguagesTab()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to edit and cancel on Languages Tab", null, ((string[])(null)));
#line 104
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 105
 testRunner.Given("I navigate to Profile and click Languages Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 106
testRunner.And(": Click on edit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
testRunner.When("I click Cancel button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 108
testRunner.Then("The Languages tab is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to edit and cancel on Skills Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfUserIsAbleToEditAndCancelOnSkillsTab()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to edit and cancel on Skills Tab", null, ((string[])(null)));
#line 110
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 111
 testRunner.Given("I navigate to Profile and click Skills Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 112
testRunner.And(": Click on edit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
testRunner.When("I click Cancel button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 114
testRunner.Then("The Skills tab is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to edit and cancel on Certifications Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfUserIsAbleToEditAndCancelOnCertificationsTab()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to edit and cancel on Certifications Tab", null, ((string[])(null)));
#line 116
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 117
 testRunner.Given("Click Certifications Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 118
testRunner.And(": Click on edit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
testRunner.When("I click Cancel button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
testRunner.Then("The Certification tab is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if user is able to edit and Save description")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "SpecFlowFeature1")]
        public virtual void CheckIfUserIsAbleToEditAndSaveDescription()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to edit and Save description", null, ((string[])(null)));
#line 122
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 123
 testRunner.Given("Click edit button on Description Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 124
testRunner.When("I enter details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 125
testRunner.And("Click Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
testRunner.Then("The Description is added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
