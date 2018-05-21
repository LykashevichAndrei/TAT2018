using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_DEV_10
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://av.by/");
            IWebElement element=driver.FindElementByClassName("js-brands-show-all");
            element.Click();
            element = driver.FindElementByXPath("//span[text()=args[0]");
            element.Click();
            MarkPage markPage = new MarkPage(driver);

        }
    }
}
