using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumProjectMail;
using OpenQA.Selenium.Chrome;
using System.Threading;



namespace TestSendMessage
{
    [TestClass]
    public class MailTest
    {
        [TestMethod]
        public void LogininMail()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://mail.ru/";

            driver.Manage().Window.Maximize();

            HomePage homePage = new HomePage(driver);

            LoginPageMail loginPageMail = homePage.GoToLoginPage();

            loginPageMail.Login("anton.tiger.97");

            loginPageMail.Password("!GEKAleo97_97");

            MailPage mailPage = loginPageMail.GoToMailPage();

            Assert.IsTrue(driver.Title.ToString().Contains("anton.tiger.97@mail.ru"));

            mailPage.OpenMessage();

            mailPage.ReplyMessage("Hello!");
        }
    }
}

