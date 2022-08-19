using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumProjectMail
{
    public class MailPage: BasePage
    {
        public static readonly By _messageBox = By.CssSelector(".llc__item_unread");
        public static readonly By _replyButton = By.CssSelector(".button2_reply");
        public static readonly By _replyBox = By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div[2]/div[3]/div[5]/div/div/div[2]/div[1]/div");
        public static readonly By _sendButton = By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div[3]/div[1]/div[1]/div/button");
        public MailPage(IWebDriver driver): base(driver)
        {

        }
        public void OpenMessage()
        {
            Thread.Sleep(1000);
            Driver.WaitForElement(_messageBox, WaitMinutes).Click();
        }
        public void ReplyMessage(string message)
        {
            Driver.WaitForElement(_replyButton, WaitMinutes).Click();
            Thread.Sleep(1000);
            Driver.WaitForElement(_replyBox, WaitMinutes).SendKeys(message);
            Driver.WaitForElement(_sendButton, WaitMinutes).Click();
        }
    }
}
