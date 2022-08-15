using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject
{
    public static class WebdriverExtensions
    {
        public static IWebElement WaitForElement(this IWebDriver driver, By by, TimeSpan timeoutInSeconds)
        {
                var wait = new WebDriverWait(driver, timeoutInSeconds);
                return wait.Until(drv => drv.FindElement(by));
            
        }
    }
}
