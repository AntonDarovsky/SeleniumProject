using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumProjectMail
{
    public class LoginPageMail : BasePage
    {
        public static readonly By _loginEditBox = By.XPath("//input[@name='username']");
        public static readonly By _passwordEditBox = By.XPath("//input[@name='password']");
        public static readonly By _loginButton = By.XPath("//*[@id='root']/div/div/div/div[2]/div/div/form/div[2]/div[2]/div[3]/div/div/div[1]/button");
        public static readonly By _passwordButton = By.XPath("//*[@id='root']/div/div/div/div[2]/div/div/form/div[2]/div/div[3]/div/div/div[1]/div/button");
        public static readonly By _frameAvailablelogin = By.CssSelector("iframe.ag-popup__frame__layout__iframe");
        
        public LoginPageMail(IWebDriver driver) : base(driver)
        {

        }
        public void Login(string nick)
        {
            Driver.WaitForFrameAndSwitchToIt(_frameAvailablelogin, WaitMinutes);
            Driver.WaitForElement(_loginEditBox, WaitMinutes).SendKeys(nick);
            Driver.WaitForElement(_loginButton, WaitMinutes).Click();
            Thread.Sleep(1000);


        }
        public void Password(string password)
        {
            Driver.WaitForElement(_passwordEditBox, WaitMinutes).SendKeys(password);
            Thread.Sleep(1000);

        }
        public MailPage GoToMailPage()
        {
            Driver.WaitForElement(_passwordButton, WaitMinutes).Click();
            return new MailPage(Driver);
            
        }
    }
}
