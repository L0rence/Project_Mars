using System;
using OpenQA.Selenium;

namespace MarsProject.Pages
{
    public class DescriptionPage
    {
        private IWebDriver driver;

        public DescriptionPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // ########### CREATE PAGE FACTORY  ####################//
        private IWebElement editIcon_description => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
        private IWebElement textArea_description => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
        private IWebElement saveBtn => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));

         
        public void clickEditIconBtn(IWebDriver driver)
        {
            editIcon_description.Click();
        }
        public void enterTextArea(IWebDriver driver)
        {
            textArea_description.SendKeys("xxx");
        }
        public void clickSaveBtn(IWebDriver driver)
        {
            saveBtn.Click();
        }

    }
}
