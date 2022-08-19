using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace SeleniumProject
{
    public class HomePage: BasePage
    {
        const string _loginButtonXpath = "/html/body/header/div/div/div/a[2]";

        Dictionary<string, IWebElement> _dictonary;
        public HomePage(IWebDriver driver) : base(driver)
        {
            _dictonary = new Dictionary<string, IWebElement>();
            var loginButton = FindElementByXpath(_loginButtonXpath);
            _dictonary.Add("Login Button", loginButton);
        }
        public LoginPageGmail GoToLoginPage()
        {
            _dictonary["Login Button"]?.Click();
            return new LoginPageGmail(Driver);
        } 
    }
}
