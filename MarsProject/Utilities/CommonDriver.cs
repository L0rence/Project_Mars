using System;
using MarsProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;


namespace MarsProject.Utilities
{
     class CommonDriver
    {
        //init driver
        public IWebDriver driver;
      
         [OneTimeSetUp]
         public void LoginProfile()
         {
           // Browser Launch 
            // driver = new FirefoxDriver();
            driver = new ChromeDriver();

            // page objects

            LoginPage loginObj = new LoginPage(driver);
             loginObj.loginSteps(driver);


         }

        [OneTimeTearDown]
         public void finalStep()
         {
            driver.Close();
        }

         
    }
}
