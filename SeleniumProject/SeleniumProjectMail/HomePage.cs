using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumProjectMail
{
    public class HomePage : BasePage
    {
        const string _loginButtonXpath = "//*[@id='mailbox']/div[1]/button";

        Dictionary<string, IWebElement> _dictonary;
        public HomePage(IWebDriver driver) : base(driver)
        {
            _dictonary = new Dictionary<string, IWebElement>();
            var loginButton = FindElementByXpath(_loginButtonXpath);
            _dictonary.Add("Login Button", loginButton);
        }
        public LoginPageMail GoToLoginPage()
        {
            _dictonary["Login Button"]?.Click();
            return new LoginPageMail(Driver);
        }
    }
}
