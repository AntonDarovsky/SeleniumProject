using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumProject
{
    public static class WebdriverExtensions
    {
        public static IWebElement WaitForElement(this IWebDriver driver, By by, TimeSpan timeoutInSeconds)
        {
                var wait = new WebDriverWait(driver, timeoutInSeconds);
                return wait.Until(drv => drv.FindElement(by));
            
        }
        public static IWebDriver iAmOnPage(WebDriver driver,By selector, TimeSpan timeout)
        {
            
            var element = new WebDriverWait(driver, timeout);
            element.Until(ExpectedConditions.TextToBePresentInElementLocated(selector, "antonwork97@gmail.com"));
            return (IWebDriver)element;
           
        }
       
    }
}
