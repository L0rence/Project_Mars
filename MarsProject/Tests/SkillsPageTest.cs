using System;
using MarsProject.Pages;
using MarsProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace MarsProject.Tests
{
     
    [TestFixture]

    class SkillsPageTest :CommonDriver
    {
        //[SetUp]
        //public void LoginProfile()
        //{
        //    // Browser Launch 
        //    driver = new FirefoxDriver();

        //    // page objects

        //    LoginPage loginObj = new LoginPage();
        //    loginObj.loginSteps(driver);
        //}

        [Test]
        public void createSkillTest(IWebDriver driver)
        {

            // Profile Objects
            ProfilePage profileObj = new ProfilePage(driver);
             
            profileObj.navigateToSkills(driver);
            // skills Page Object
            SkillsPage skillsObj = new SkillsPage(driver);
            skillsObj.createSkills(driver);

        }

        [Test]
        public void updateSkillTest(IWebDriver driver)
        {

            // Profile Objects
            ProfilePage profileObj = new ProfilePage(driver);

            profileObj.navigateToSkills(driver);
            // skills Page Object
            SkillsPage skillsObj = new SkillsPage(driver);
            skillsObj.updateSkills(driver);

        }

        [Test]
        public void deleteSkillTest(IWebDriver driver)
        {

            // Profile Objects
            ProfilePage profileObj = new ProfilePage(driver);

            profileObj.navigateToSkills(driver);
            // skills Page Object
            SkillsPage skillsObj = new SkillsPage(driver);
            skillsObj.deleteSkills(driver);

        }

        //[TearDown]
        //public void finalStep(IWebDriver driver)
        //{
        //    driver.Close();
        //}
   
    }  
}
