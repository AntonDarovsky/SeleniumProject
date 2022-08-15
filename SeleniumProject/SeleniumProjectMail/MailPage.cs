using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumProjectMail
{
    public class MailPage: BasePage
    {
        public static readonly By _MessageBox = By.CssSelector(".llc__item_unread");
        public static readonly By _ReplyButton = By.CssSelector(".button2_reply");
        public static readonly By _replyBox = By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div[2]/div[3]/div[5]/div/div/div[2]/div[1]/div");
        public static readonly By _sendButton = By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div[3]/div[1]/div[1]/div/button");
        public MailPage(IWebDriver driver): base(driver)
        {

        }
        public void OpenMessage()
        {
            Driver.WaitForElement(_MessageBox, WaitMinutes).Click();
        }
        public void ReplyMessage(string message)
        {
            Driver.WaitForElement(_ReplyButton, WaitMinutes).Click();
            Thread.Sleep(1000);
            Driver.WaitForElement(_replyBox, WaitMinutes).SendKeys(message);
            Driver.WaitForElement(_sendButton, WaitMinutes).Click();
        }
    }
}
