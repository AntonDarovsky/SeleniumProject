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
        public static readonly By _ToEditBox = By.Id(":8n");
        public static readonly By _TopicEditBox = By.Id(":85");
        public static readonly By _MessageEditBox = By.XPath("//*[@id=':9b']");
        public static readonly By _SendButton = By.XPath("//*[@id=':7v']");
        public GmailPage(IWebDriver driver) : base(driver)
        {

        }
        public void WriteLetter(string nick,string topic, string message)
        {
            Driver.WaitForElement(_WriteButton, WaitMinutes).Click();
            Thread.Sleep(1000);
            Driver.WaitForElement(_ToEditBox, WaitMinutes).SendKeys(nick);
            
            Driver.WaitForElement(_TopicEditBox, WaitMinutes).SendKeys(topic);
            
            Driver.WaitForElement(_MessageEditBox, WaitMinutes).SendKeys(message);
            Thread.Sleep(1000);
            Driver.FindElement(_SendButton).Click();
        }
    }
}
