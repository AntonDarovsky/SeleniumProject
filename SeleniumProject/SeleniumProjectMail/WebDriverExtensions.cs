using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.WaitHelpers;


namespace SeleniumProjectMail
{
    public static class WebdriverExtensions
    {
        public static IWebElement WaitForElement(this IWebDriver driver, By by, TimeSpan timeoutInSeconds)
        {
            var wait = new WebDriverWait(driver, timeoutInSeconds);
            return wait.Until(drv => drv.FindElement(by));

        }
        public static IWebDriver WaitForFrameAndSwitchToIt(this IWebDriver webDriver, By selector, TimeSpan timeout)
        {
            var wait = new WebDriverWait(webDriver, timeout);
            return wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(selector));
        }
    }
}
