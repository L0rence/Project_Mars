using System;
using MarsProject.Pages;
using MarsProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace MarsProject.Tests
{
    
    [TestFixture]
    class EducatioPageTest : CommonDriver
    {
       // [SetUp]
       // public void LoginProfile()
       // {
       //     // Browser Launch 
       //     driver = new FirefoxDriver();

       //     // page objects

       //     LoginPage loginObj = new LoginPage();
       //     loginObj.loginSteps(driver);

       //}

        [Test]
        public void createEducatioTest()
        {

            // Profile Objects
            ProfilePage profileObj = new ProfilePage(driver);
            profileObj.navigateToEducation(driver);
            // education Page Object
            EducationPage educationObj = new EducationPage(driver);
            educationObj.createEducation(driver);
             
        }

        [Test]
        public void updateEducatioTest()
        {

            // Profile Objects
            ProfilePage profileObj = new ProfilePage(driver);
            profileObj.navigateToEducation(driver);
            // education Page Object
            EducationPage educationObj = new EducationPage(driver);
            educationObj.updateEducation(driver);

        }

        [Test]
        public void deleteEducatioTest()
        {

            // Profile Objects
            ProfilePage profileObj = new ProfilePage(driver);
            profileObj.navigateToEducation(driver);
            // education Page Object
            EducationPage educationObj = new EducationPage(driver);
            educationObj.deleteEducation(driver);

        }

        //[TearDown]
        //public void finalStep(IWebDriver driver)
        //{
        //    driver.Close();
        //}
    
    } 
}
