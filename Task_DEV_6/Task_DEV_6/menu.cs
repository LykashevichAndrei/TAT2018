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
            string n=string.Empty;
            string temp;
            do
            {
                Console.WriteLine("1-Add product");
                Console.WriteLine("2-Enter a function");
                Console.WriteLine("3-Exit");
                temp = EnterNumber(n);
            } 
            while (temp != "3") ;
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
                        CountTypes CP = new CountTypes(products);
                        CP.Calculate();
                    }
                    break;
                case "count types":
                    {
                        CountTypes CP = new CountTypes(products);
                        CP.Calculate();
                    }
                    break;
                case "Count all":
                    {
                        CountAll CA = new CountAll(products);
                        CA.Calculate();
                    }
                    break;
                case "count all":
                    {
                        CountAll CA = new CountAll(products);
                        CA.Calculate();
                    }
                    break;
                case "Average price":
                    {
                        AveragePrice AP = new AveragePrice(products);
                        AP.Calculate();
                    }
                    break;
                case "average price":
                    {
                        AveragePrice AP = new AveragePrice(products);
                        AP.Calculate();
                    }
                    break;
                case "Average price with type":
                    {
                        AveragePriceWithType APWT = new AveragePriceWithType(products);
                        APWT.Calculate();
                    }
                    break;
                case "average price with type":
                    {
                        AveragePriceWithType APWT = new AveragePriceWithType(products);
                        APWT.Calculate();
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
