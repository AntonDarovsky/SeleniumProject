using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumProject;
using System.Threading;



namespace TestSendMessage
{
    [TestClass]
    public class GmailTest
    {
        [TestMethod]
        public void LogininGmail()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://www.google.com/intl/ru/gmail/about/";

            driver.Manage().Window.Maximize();

            HomePage homePage = new HomePage(driver);

            LoginPageGmail loginPageGmail = homePage.GoToLoginPage();
            
            loginPageGmail.LanguageSelect();
            Thread.Sleep(1000);
            loginPageGmail.Login("antonwork97@gmail.com");
            Thread.Sleep(1000);
            loginPageGmail.Password("antonleo1");
            Thread.Sleep(1000);

            GmailPage gmailPage = loginPageGmail.GoToGmailPage();
            Thread.Sleep(1000);

            gmailPage.WriteLetter("anton.tiger.97@mail.ru","Message to mail.ru", "Hello!");

           

        }
    }
}
