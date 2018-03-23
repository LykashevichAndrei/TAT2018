using System;
using System.Collections.Generic;

namespace Task_DEV_6
{
    /// <summary>
    /// class with our main menu
    /// </summary>
    class menu
    {
        List<Product> products = new List<Product>();
        /// <summary>
        /// select product input or function call
        /// </summary>
        public void MainMenu()
        {
            string n = string.Empty;
            string temp;
            do
            {
                Console.WriteLine("1-Add product");
                Console.WriteLine("2-Enter a function");
                Console.WriteLine("3-Exit");
                temp = EnterNumber(n);
            }
            while (temp != "3");
            return;
        }
        private void FunctionInput()
        {
            Console.WriteLine("Count types");
            Console.WriteLine("Count all");
            Console.WriteLine("Average price");
            Console.WriteLine("Average price with type");
            string comand;
            comand = Console.ReadLine();

            switch (comand)
            {
                case "Count types":
                    {
                        double temp;
                        CountTypes CP = new CountTypes(products);
                        temp = CP.Calculate();
                        Console.WriteLine(temp);
                    }
                    break;
                case "count types":
                    {
                        double temp;
                        CountTypes CP = new CountTypes(products);
                        temp=CP.Calculate();
                        Console.WriteLine(temp);
                    }
                    break;
                case "Count all":
                    {
                        double temp;
                        CountAll CA = new CountAll(products);
                        temp = CA.Calculate();
                        Console.WriteLine(temp);
                    }
                    break;
                case "count all":
                    {
                        double temp;
                        CountAll CA = new CountAll(products);
                        temp = CA.Calculate();
                        Console.WriteLine(temp);
                    }
                    break;
                case "Average price":
                    {
                        double price;
                        AveragePrice AP = new AveragePrice(products);
                        price = AP.Calculate();
                        Console.WriteLine(price);
                    }
                    break;
                case "average price":
                    {
                        double price;
                        AveragePrice AP = new AveragePrice(products);
                        price = AP.Calculate();
                        Console.WriteLine(price);
                    }
                    break;
                case "Average price with type":
                    {
                        double price;
                        AveragePriceWithType APWT = new AveragePriceWithType(products);
                        price = APWT.Calculate();
                        Console.WriteLine(price);
                    }
                    break;
                case "average price with type":
                    {
                        double price;
                        AveragePriceWithType APWT = new AveragePriceWithType(products);
                        price = APWT.Calculate();
                        Console.WriteLine(price);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("check that the command is correct");
                        return;
                    }
            }
        }
        private string EnterNumber(string n)
        {
            n = Console.ReadLine();
            switch (n)
            {
                case "1":
                    {
                        products.Add(new Product());
                    }
                    break;
                case "2":
                    {
                        FunctionInput();
                    }
                    break;
                case "3":
                    {
                        return "3";
                    }
                default:
                    {
                        Console.WriteLine("enter number from 1 to 3");
                    }
                    break;
            }

            return n;
        }
    }
}
