using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_02_05_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://av.by/");
            IWebElement element = driver.FindElementByName("brand_id[]");
            element.Click();
            CarListPage FirstPage = new CarListPage(driver);
            driver = FirstPage.OpenCarList(element);
            Thread.Sleep(1000);
            FirstPage.DeduceThePriceOfTheCheapestCar(element);
        }
    }
}
