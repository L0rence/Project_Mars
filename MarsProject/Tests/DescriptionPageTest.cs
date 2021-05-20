using System;
using MarsProject.Pages;
using MarsProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MarsProject.Tests
{
    [TestFixture]
    class DescriptionPageTest : CommonDriver
    {
        [Test]
        public void createDescription()
        {
            DescriptionPage  descriptionPage = new DescriptionPage(driver);
            descriptionPage.clickEditIconBtn(driver);

        }
    }
}
