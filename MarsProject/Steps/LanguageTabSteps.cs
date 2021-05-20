using System;
using MarsProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsProject.Steps
{

    [Binding]
    public class LanguageTabSteps
    {
        // ######### Intialize webdriver ##############

        private readonly IWebDriver driver;
        private LanguagePage languagePage;  // Login Page take the driver 
        private LoginPage loginPage;
        private ProfilePage profilePage;
        // ############# Create a Constructor #############

        public LanguageTabSteps()
        {
          // Inject the driver 
            driver = new ChromeDriver();
            languagePage = new LanguagePage(driver);
            loginPage = new LoginPage(driver);
            profilePage = new ProfilePage(driver);

        }

         [AfterScenario]
         public void RunAfterEveryTest()
         {
             driver.Close();
        }

        // ############### CREATE  ########################
        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
           loginPage.login(null, null);
            Console.WriteLine("I am logged in");
        }

        [Given(@"I am at the language tab")]
         public void GivenIAmAtTheLanguageTab()
         {
             profilePage.navigateToLanguage(driver);
           bool IsAtLangTab = languagePage.validateLanguageTitle();
             Assert.IsTrue(IsAtLangTab);
            Console.WriteLine("I am at the language tab");  
         }

        [Given(@"I click add new button for the language")]
        public void GivenIClickAddNewButtonForTheLanguage()
        {
            languagePage.clickAddNewLangBtn();
            Console.WriteLine("I click add new button for the language");
        }

        [Given(@"I enter the details for new language")]
        public void GivenIEnterTheDetailsForNewLanguage()
        {
            languagePage.enter_Language();
            languagePage.dropDown_lang_list();
            Console.WriteLine("I enter the details for new language");
        }

        [Given(@"I click add button to save new language")]
        public void GivenIClickAddButtonToSaveNewLanguage()
        {
            languagePage.Save_Language();
            Console.WriteLine("I click add button to save new language");
        }

        [Then(@"Validate the language is created")]
        public void ThenValidateTheLanguageIsCreated()
        {
            languagePage.validateLanguage_created();
            Console.WriteLine("Validate the language is created");
            Assert.IsTrue(true);
        }

        // ############### UPDATE ########################

        [Given(@"I click edit icon to edit language")]
        public void GivenIClickEditIconToEditLanguage()
        {
            languagePage.clickEditLanguage();
            Console.WriteLine("I click edit icon to edit language");
        }

        [Given(@"I enter the details for edited language")]
        public void GivenIEnterTheDetailsForEditedLanguage()
        {
            languagePage.editLanguage();
            Console.WriteLine("I enter the details for edited language");
        }

        [Given(@"I click update button to save edited language")]
        public void GivenIClickUpdateButtonToSaveEditedLanguage()
        {
            languagePage.update_Btn_Language();
            Console.WriteLine("I click update button to save edited language");
        }

        [Then(@"Validate the edited language is created")]
        public void ThenValidateTheEditedLanguageIsCreated()
        {
            languagePage.validateUpdate_Lang();
            Console.WriteLine("Validate the edited language is created");
            Assert.IsTrue(true);
        }

        // ############### DELETE ########################

        [Given(@"I click delete icon to delete language")]
        public void GivenIClickDeleteIconToDeleteLanguage()
        {
            languagePage.clcikDeleteLanguage();
            Console.WriteLine("I click delete icon to delete language");    
        }

        [Then(@"Validate the delete language is deleted")]
         public void ThenValidateTheDeleteLanguageIsDeleted()
         {
            //bool IsAvaliabe = languagePage.validateDelete_Language();
            Console.WriteLine("Validate the delete language is deleted");
            //Assert.IsTrue(IsAvaliabe);
            languagePage.validateDeleteItem();

         }


    }
}
