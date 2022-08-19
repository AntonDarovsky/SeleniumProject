using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumProject
{
    public abstract class BasePage
    {
        public static TimeSpan WaitMinutes = TimeSpan.FromMinutes(2);
        public IWebDriver Driver { get; }

        public BasePage (IWebDriver driver)
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
                catch(Exception exp)
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
