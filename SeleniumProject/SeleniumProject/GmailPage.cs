using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumProject
{
    public class GmailPage: BasePage
    {
        public static readonly By _WriteButton = By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[1]/div/div");
        public static readonly By _ToEditBox = By.Id("90");
        public static readonly By _TopicEditBox = By.Id(":85");
        public static readonly By _MessageEditBox = By.XPath("//*[@id=':9b']");
        public static readonly By _SendButton = By.XPath("//*[@id=':7v']");
        public static readonly By _accountButton = By.XPath("//*[@id='gb']/div[2]/div[3]/div[1]/div[2]/div/a");
        

        public GmailPage(IWebDriver driver) : base(driver)
        {
           
        }
        
        public void CheckPage()
        {
            Driver.WaitForElement(_accountButton, WaitMinutes).Click();
        }
       
        public void OpenLetter()
        {
            Driver.WaitForElement(_WriteButton, WaitMinutes).Click();
            Thread.Sleep(1000);

        }
        public void WriteToTextBox(string nick)
        { 
            Driver.WaitForElement(_ToEditBox, WaitMinutes).SendKeys(nick);
            Thread.Sleep(1000);
        }
        public void WriteTopicTextBox(string topic)
        {
            Driver.WaitForElement(_TopicEditBox, WaitMinutes).SendKeys(topic);
            Thread.Sleep(1000);
        }
        public void WriteMessageTextBox(string message)
        {
            Driver.WaitForElement(_MessageEditBox, WaitMinutes).SendKeys(message);
            Thread.Sleep(1000);
            Driver.FindElement(_SendButton).Click();
        }
    }
}
