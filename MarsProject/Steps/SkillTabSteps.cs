using System;
using MarsProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsProject.Steps
{
    [Binding]
    public class SkillTabSteps
    {
        // ######### Intialize webdriver ##############

        private readonly IWebDriver driver;
        //private LanguagePage languagePage;  // Login Page take the driver 
        private LoginPage loginPage;
        private SkillsPage skillsPage;
        private ProfilePage profilePage;
        // ############# Create a Constructor #############

        public SkillTabSteps()
        {
            // Inject the driver 
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            skillsPage = new SkillsPage(driver);
            profilePage = new ProfilePage(driver);


        }
        [AfterScenario]
        public void RunAfterEveryTest()
        {
            driver.Close();
        }

        // ############ CREATE Methods#############
        [Given(@"I am logged into")]  
        public void GivenIAmLoggedIn() 
        {
            loginPage.login(null, null);
            Console.WriteLine("I am logged in");
        }
         [Given(@"I click on the skills tab")]
         public void IClickOnTheSkillsTab()
         {
             skillsPage.clickOnSkillTabLink();
          Console.WriteLine("I click on the skills tab");
        }
        [Given(@"I click add new button for the skills")]
        public void GivenIClickAddNewButtonForTheSkills()
        {
            skillsPage.clickOnANewBtn_skills();
            Console.WriteLine("I click add new button for the skills");
        }

        [Given(@"I enter the details for new skills")]
        public void GivenIEnterTheDetailsForNewSkills()
        {
            skillsPage.enterNewSkills();
            skillsPage.selectDropdownSkills_create();
            Console.WriteLine("I enter the details for new skills"); 
        }

        [Given(@"I click add button to save new skills")]
        public void GivenIClickAddButtonToSaveNewSkills()
        {
            skillsPage.addNewBtnToSaveSkill();
            Console.WriteLine("I click add button to save new skills");
        }
        [Then(@"Validate the skills is created")]
        public void ThenValidateTheSkillsIsCreated()
        {
            skillsPage.validateSkill_created(); 
        }

        //################## UPDATE METHOD #################

        [Given(@"I click edit icon to edit skills")]
        public void GivenIClickEditIconToEditSkills()
        {
            skillsPage.clickOnEditBtn();
            Console.WriteLine("I click edit icon to edit skills");
        }


        [Given(@"I enter the details for edited skill details")]
        public void GivenIEnterTheDetailsForEditedSkillDetails()
        {
            skillsPage.enterEditSkill();
            skillsPage.selectDropdownSkill_edit();
            Console.WriteLine("I enter the details for edited skill details");
        }


        [Given(@"I click update button to save edited skills")]
        public void GivenIClickUpdateButtonToSaveEditedSkills()
        {
            skillsPage.updateToSaveSkill();
            Console.WriteLine("I click update button to save edited skills");
        }


        [Then(@"Validate the edited skills is created")]
        public void ThenValidateTheEditedSkillsIsCreated()
        {
            skillsPage.validateUpdate_Skill();
            Console.WriteLine("Validate the edited skills is created");
        }

        //############DELETE Methods ###################

        [Given(@"I click delete icon to delete skills")]
        public void GivenIClickDeleteIconToDeleteSkills()
        {
            skillsPage.clickOnDeleteBtn();
            Console.WriteLine("I click delete icon to delete skills");
        }
        [Then(@"I Validate the delete skill")]
        public void IValidateTheDeleteSkill()
        {
            skillsPage.validatedeleteSkill();
            Console.WriteLine("I Validate the delete skill");
            
        }


    }
}
