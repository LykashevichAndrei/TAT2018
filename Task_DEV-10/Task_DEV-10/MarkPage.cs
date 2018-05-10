using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_DEV_10
{
    class MarkPage
    {
        ChromeDriver driver;
        public MarkPage(ChromeDriver Driver)
        {
            this.driver = Driver;
        }
        public void DisplayModels()
        {
            IWebElement element;
            List<string> models=new List<string>();
            List<string> quantity=new List<string>();
            var cars= driver.FindElementsByClassName("brandsitem brandsitem--primary");
            foreach(var el in cars)
            {
                element=driver.FindElementByXPath("//cpan");
                models.Add(element.Text);
                element = driver.FindElementByXPath("//small");
                quantity.Add(element.Text);
            }
            int i = 0;
            foreach(string el in models)
            {
                Console.WriteLine(el + " " + quantity[i]);
                i++;
            }
        }
    }
}
