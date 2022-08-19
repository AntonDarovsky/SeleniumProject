using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumProjectMail
{
    public abstract class BasePage
    {
        public static TimeSpan WaitMinutes = TimeSpan.FromMinutes(1);
        public IWebDriver Driver { get; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement FindElementByXpath(string xPath)
        {
            IWebElement element = null;

            int attempsnumber = 0;

            while (attempsnumber < 10)
            {
                try
                {
                    element = Driver.FindElement(By.XPath(xPath));
                }
                catch (Exception exp)
                {
                    Thread.Sleep(1000);
                }
                if (element != null)
                {
                    break;
                }
                attempsnumber++;
            }
            return element;
        }


    }
}
