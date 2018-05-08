using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_02_05_2018
{
    class CarListPage
    {
        private ChromeDriver driver;
        public CarListPage(ChromeDriver Driver)
        {
            this.driver = Driver;
        }
        public ChromeDriver OpenCarList(IWebElement element)
        {
            element = driver.FindElementByXPath("//option[text()='BMW']");
            element.Click();
            element = driver.FindElementById("model_id");
            element.Click();
            element = driver.FindElementByXPath("//option[text()='M5']");
            element.Click();
            element = driver.FindElementById("submit_presearch");
            element.Click();
            return driver;
        }
        public void DeduceThePriceOfTheCheapestCar(IWebElement element)
        {
            element = driver.FindElementByXPath("//a[text()='цене']");
            element.Click();
            element = driver.FindElementByXPath("//small");
            Console.WriteLine(element.Text);
        }
    }
}
