using System;
using MarsProject.Pages;
using MarsProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace MarsProject.Tests
{
    [TestFixture]
    class CertificationPageTest :CommonDriver
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
        public void createCertificationTest(IWebDriver driver)
        {

            // Profile Objects
            ProfilePage profileObj = new ProfilePage(driver);

            profileObj.navigateToCertification(driver);
            // certification Page Object
            CertificationPage certificationObj = new CertificationPage(driver);
            certificationObj.createCertification(driver);
            

        }

        [Test]
        public void updateCertificationTest(IWebDriver driver)
        {

            // Profile Objects
            ProfilePage profileObj = new ProfilePage(driver);

            profileObj.navigateToCertification(driver);
            // certification Page Object
            CertificationPage certificationObj = new CertificationPage(driver);
            certificationObj.updateCertification(driver);


        }

        [Test]
        public void deleteCertificationTest(IWebDriver driver)
        {

            // Profile Objects
            ProfilePage profileObj = new ProfilePage(driver);

            profileObj.navigateToCertification(driver);
            // certification Page Object
            CertificationPage certificationObj = new CertificationPage(driver);
            certificationObj.deleteCertification(driver);


        }

        //[TearDown]
        //public void finalStep(IWebDriver driver)
        //{
        //    driver.Close();
        //}
         
    }
}
