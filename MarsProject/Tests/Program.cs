using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using MarsProject.Pages;
using NUnit.Framework;
using MarsProject.Utilities;

namespace MarsProject
{

     
    [TestFixture]
     class Program : CommonDriver
    {
        
        [Test]
        public void createLanguageTest()
        {

            // Profile Objects
            ProfilePage profileObj = new ProfilePage(driver);
            profileObj.navigateToLanguage(driver);
            // language Page Object
            LanguagePage languageObj = new LanguagePage(driver);
            languageObj.createLanguage(driver);
           

        }
        [Test]
        public void updateLanguageTest()
        {
            //update language
            ProfilePage profileObj = new ProfilePage(driver);
            profileObj.navigateToLanguage(driver);
            // language Page Object
            LanguagePage languageObj = new LanguagePage(driver);
            languageObj.updateLanguage(driver);
        }
        [Test]
        public void deleteLanguageTest()
        {
            //delete language
            ProfilePage profileObj = new ProfilePage(driver);
            profileObj.navigateToLanguage(driver);
            // language Page Object
            LanguagePage languageObj = new LanguagePage(driver);
            languageObj.deleteLanguage(driver);
        }



        // moved from the above code for setup and tear down 
        //[SetUp]
        //public void LoginProfile()
        //{
        //    // Browser Launch 
        //    driver = new FirefoxDriver();

        //    // page objects

        //    LoginPage loginObj = new LoginPage();
        //    loginObj.loginSteps(driver);


        //}
        //[TearDown]
        //public void finalStep(IWebDriver driver)
        //{
        //    driver.Close();
        //}



    }
}
