using System;
using MarsProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using MarsProject.Pages;
 

namespace MarsProject.Tests
{
    [TestFixture]
    //public class LanguagePageTest
    //{
         
   
     
    class LanguagePageTest : CommonDriver
    {
        

        [Test]
        public void createLanguageTest(IWebDriver driver)
        {

            // Profile Objects
            ProfilePage profileObj = new ProfilePage(driver);
            //profileObj.navigateToEducation(driver);
            profileObj.navigateToLanguage(driver);
            // language Page Object
            LanguagePage languageObj = new LanguagePage(driver);
            languageObj.createLanguage(driver);
                 
        }

        [Test]
        public void updateLanguageTest(IWebDriver driver)
        {

            // Profile Objects
            ProfilePage profileObj = new ProfilePage(driver);
            //profileObj.navigateToEducation(driver);
            profileObj.navigateToLanguage(driver);
            // language Page Object
            LanguagePage languageObj = new LanguagePage(driver);
                languageObj.updateLanguage(driver);

            }

        [Test]
        public void deleteLanguageTest(IWebDriver driver)
        {

            // Profile Objects
            ProfilePage profileObj = new ProfilePage(driver);
            //profileObj.navigateToEducation(driver);
            profileObj.navigateToLanguage(driver);
            // language Page Object
            LanguagePage languageObj = new LanguagePage(driver);
            languageObj.deleteLanguage(driver);

            }

         
     
        }
    //}
}
