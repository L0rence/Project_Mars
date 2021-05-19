﻿using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace MarsProject.Pages
{
    public class LanguagePage
    {
         
        private IWebDriver driver;




        // ###########  CONSTRUCTOR  ####################//

        public LanguagePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // ###########  CREATE PAGE FACTORY DESIGN PATTERN ####################//

        IWebElement SignUpLink => driver.FindElement(By.XPath("//a[contains(text(),'Sign In')]"));
        IWebElement AddNewBtnLanguage => driver.FindElement(By.CssSelector("div[class='ui bottom attached tab segment active tooltip-target'] div[class='ui teal button ']"));
        IWebElement enterLanguage => driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        IWebElement languageDropdown => driver.FindElement(By.XPath("//option[@value='Fluent']"));
        IWebElement saveLanguage => driver.FindElement(By.XPath("//input[@value='Add']"));
        IWebElement lastEntryResult_Lang => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));

        // #################UPDATE PAGE FACTORY ############
        IWebElement clickEditBtnLang => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]"));
        IWebElement editLang => driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        IWebElement dropDown_edit_Lang => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[5]"));
        IWebElement updateBtnLang => driver.FindElement(By.XPath("//input[@value='Update']"));

        // #################DELETE PAGE FACTORY ############
        IWebElement delete_Language => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
       // IWebElement deleteRow => driver.FindElement(By.XPath("//td[normalize-space()='Tamil']"));
        //IWebElement deleteValidation => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        // ####### Validate Page factory #########
        IWebElement Lang_title => driver.FindElement(By.XPath("//h3[normalize-space()='Languages']"));
        
        public bool validateLanguageTitle()
        {
            return Lang_title.Displayed;
        }

        //// ############### CREATE Methods ###############
        public void clickAddNewLangBtn()
        {
            // Identify and Click AddNew 
            //IWebElement Language_addNew_Btn = driver.FindElement(By.CssSelector("div[class='ui bottom attached tab segment active tooltip-target'] div[class='ui teal button ']"));
            AddNewBtnLanguage.Click();
        }

        public void enter_Language()
        {
            enterLanguage.SendKeys("English");
            Thread.Sleep(500);
        }
        public void dropDown_lang_list()
        {
            languageDropdown.Click();
            Thread.Sleep(500);
        }

        public void Save_Language()
        {
            saveLanguage.Click();
            Thread.Sleep(500);
        }
        public bool validateLanguage_created()
        {
            if(lastEntryResult_Lang.Text == "English")
            {
                Console.WriteLine("Language is created Successfully!!, Test Pass!!");
                return true;
                
            }
            else
            {
                Console.WriteLine("Language is not created, Test Failed!!!!");
                return false;
                
            }
        }

        // ####################UPDATE METHODS #################

        public void clickEditLanguage()
        {
            clickEditBtnLang.Click();
            Thread.Sleep(1000);
        }
        public void editLanguage()
        {
            editLang.SendKeys("Tamilan da");
            Thread.Sleep(1000);
            dropDown_edit_Lang.Click();

        }
         public void selectDropDown()    
         {
            IWebElement element = driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByValue("Native/Bilingual");
         }

        public void update_Btn_Language()
        {
            updateBtnLang.Click();
            Thread.Sleep(1000);
        }
        public bool validateUpdate_Lang()
        {
            if (lastEntryResult_Lang.Text == "English")
            {
                Console.WriteLine("Language is created Successfully!!, Test Pass!!");
                return true;

            }
            else
            {
                Console.WriteLine("Language is not created, Test Failed!!!!");
                return false;

            }
        }


        // ####################DELETE METHODS #################

        public void clcikDeleteLanguage()
        {
            delete_Language.Click();
        }

        //public bool validateDelete_Language()
        //{
        //    //return deleteRow.Displayed;
        //}
        public void validateDeleteItem()
        {
            IWebElement deleteValidation = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            string deleteTxt = deleteValidation.Text;
            Console.WriteLine("Delete message from pop up ========>>>>>>>> "+deleteTxt);
        }

         
                 public void createLanguage(IWebDriver driver)
                 {
                    /*
                     // Identify and Click AddNew 
                     IWebElement Language_addNew_Btn = driver.FindElement(By.CssSelector("div[class='ui bottom attached tab segment active tooltip-target'] div[class='ui teal button ']"));
                     Language_addNew_Btn.Click();

                     //  Add Language

                     IWebElement AddLanguage = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
                    AddLanguage.SendKeys("Tamil123");
                     //Thread.Sleep(1000);
                     //IWebElement element = driver.FindElement(By.CssSelector("select[name='level']"));
                     //SelectElement DropDownList = new SelectElement(element);

                     // Dropdown list 
                     IWebElement select_Native = driver.FindElement(By.XPath("//option[@value='Fluent']"));
                     select_Native.Click();
                    // Add Language
                     IWebElement addLanguage = driver.FindElement(By.XPath("//input[@value='Add']"));
                    addLanguage.Click();
                    */
                 }
                public void updateLanguage(IWebDriver driver)
                 {

                 }
                 public void deleteLanguage(IWebDriver driver)
                 {
                    //delete language 
                 }


         


    }
}