using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using SeleniumProject;
using System.Threading;



namespace TestSendMessage
{
    [TestClass]
    public class GmailTest
    {
        [TestMethod]
        public void LogininGmailandSendMessage()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://www.google.com/intl/ru/gmail/about/";

            driver.Manage().Window.Maximize();

            HomePage homePage = new HomePage(driver);

            LoginPageGmail loginPageGmail = homePage.GoToLoginPage();

            loginPageGmail.LanguageSelect();

            loginPageGmail.Login("antonwork97@gmail.com");

            loginPageGmail.Password("antonleo1");

            GmailPage gmailPage = loginPageGmail.GoToGmailPage();

            gmailPage.CheckPage();

            Assert.IsTrue(driver.Title.ToString().Contains("antonwork97@gmail.com"));

            gmailPage.OpenLetter();

            gmailPage.WriteToTextBox("anton.tiger.97@mail.ru");

            gmailPage.WriteTopicTextBox("Message to Mail");

            gmailPage.WriteMessageTextBox("Hello!");
        

           

        }
    }
}
