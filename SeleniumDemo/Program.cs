using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Runtime;
using System.Threading;
using System;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
using OpenQA.Selenium.Support.Extensions;
using System.Data;
using System.Drawing;
using OpenQA.Selenium.Interactions;

namespace SeleniumTest
{
    class Program
    {

        static void Main(string[] args)

        {

            ChromeOptions options = new ChromeOptions(); //definiranje profila
             
            options.AddArgument("disable-infobars");
            options.AddArgument("--disable-web-security");
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("-ignore-certificate-errors");
            options.AddUserProfilePreference("profile.default_content_setting_values.notifications", 1);
            IWebDriver driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl("https://www.getihub.com/login"); //navigacija
            IWebElement element = driver.FindElement(By.CssSelector("[type = button]"));
            Thread.Sleep(1000);
            driver.Manage().Window.Maximize();
            string text = "zvonimir.knezevic";
            string text1 = "@serengetitech.com";
            element.Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Name("loginfmt")).SendKeys(text);
            Thread.Sleep(1000);
            driver.FindElement(By.Name("loginfmt")).SendKeys(text1);
            driver.FindElement(By.Id("idSIButton9")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("i0118")).SendKeys("Zvone9922" + Keys.Enter);

            Thread.Sleep(1000);
            driver.FindElement(By.Id("idSIButton9")).Click();
            Thread.Sleep(2000);
        
            driver.Navigate().GoToUrl("https://www.getihub.com/timesheet/landing");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("[class = event-header-button]")).Click();
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("[type = button]")).Click();
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("5")).Click();
            Thread.Sleep(1000);
          
            driver.FindElement(By.XPath("//*[@aria-label= '7:30-15:30']")).Click();
            Thread.Sleep(1000);

            IWebElement element1 = driver.FindElement(By.XPath("//*[@for = 'projectId']"));

            element1.Click();
            driver.FindElement(By.XPath("//*[@role = 'listbox']")).Click();
            Thread.Sleep(2000);
            IWebElement element2 = driver.FindElement(By.XPath("//*[@for = 'taskId']"));
            element2.Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@role = 'listbox']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@type = 'submit']")).Submit(); 
            Thread.Sleep(2000);
            driver.Navigate().Refresh();
            Thread.Sleep(3000);
            


            driver.Quit();

        }

    }
}