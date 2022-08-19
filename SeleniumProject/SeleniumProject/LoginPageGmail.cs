using OpenQA.Selenium;
using System;
using System.Threading;

namespace SeleniumProject
{
    public class LoginPageGmail: BasePage
    {
        

        public static readonly By _loginEditBoxXpath = By.Id("identifierId");
        public static readonly By _passwordEditBoxXpath = By.XPath("//*[@id='password']/div[1]/div/div[1]/input");
        public static readonly By _loginButtonXpath = By.Id( "identifierNext");
        public static readonly By _passwordButtonXpath = By.Id("passwordNext");
        public static readonly By _languageSelectorXpath = By.Id("lang-chooser");
        public static readonly By _englishLanguageXpath = By.XPath("//*[@id='lang-chooser']/div[2]/div[10]");
       
        public LoginPageGmail(IWebDriver driver): base(driver)
        {
            
        }

        public void LanguageSelect()
        {
            Driver.WaitForElement(_languageSelectorXpath, WaitMinutes).Click();
          
            Driver.WaitForElement(_englishLanguageXpath, WaitMinutes).Click();
            Thread.Sleep(1000);

        }
        public void Login(string nick)
        {
           
            Driver.WaitForElement(_loginEditBoxXpath, WaitMinutes).SendKeys(nick);
            Driver.WaitForElement(_loginButtonXpath, WaitMinutes).Click();
            


        }
        public void Password( string password)
        {
            Thread.Sleep(1000);
            Driver.WaitForElement(_passwordEditBoxXpath, WaitMinutes).SendKeys(password);
            

        }
        public GmailPage GoToGmailPage()
        {
            Driver.WaitForElement(_passwordButtonXpath, WaitMinutes).Click();
            return new GmailPage(Driver);
        }
    }
}
