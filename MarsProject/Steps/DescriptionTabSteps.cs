using System;
using MarsProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsProject.Steps
{
    [Binding]
    public class DescriptionTabSteps
    {
        // ######### Intialize webdriver ##############

        private readonly IWebDriver driver;
        private LoginPage loginPage;
        private DescriptionPage descriptionPage;
       

        // ############# Create a Constructor #############

        public DescriptionTabSteps()
        {
            // Inject the driver 
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            descriptionPage = new DescriptionPage(driver);

        }
        [AfterScenario]
        public void RunAfterEveryTest()
        {
            driver.Close();
        }


        [Given(@"i am logged in")]
        public void GivenIAmLoggedIn()
        {
            loginPage.login(null, null);
            Console.WriteLine("i am logged in");
        }

        [Given(@"i have click edit icon to enter the details of description")]
        public void GivenIHaveClickEditIconToEnterTheDetailsOfDescription()
        {
            descriptionPage.clickEditIconBtn(driver);
            descriptionPage.enterTextArea(driver);
            Console.WriteLine("i have click edit icon to enter the details of description");
        }

        [When(@"i press save button")]
        public void WhenIPressSaveButton()
        {
            descriptionPage.clickSaveBtn(driver);
            Console.WriteLine("i press save button");
        }

        [Then(@"validate the result")]
        public void ThenValidateTheResult()
        {
            Console.WriteLine("validate the result");
        }
    }
}
