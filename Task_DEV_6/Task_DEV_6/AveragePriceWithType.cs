﻿using System;
using System.Collections.Generic;

namespace Task_DEV_6
{
    /// <summary>
    /// class that counts the value of all goods
    /// </summary>
    class AveragePriceWithType : ICalculate
    {
        private List<Product> MyList;
        public AveragePriceWithType(List<Product> products)
        {
            this.MyList = products;
        }
        /// <summary>
        /// counts the value of all goods
        /// </summary>
        public void Calculate()
        {
            string MyType= Console.ReadLine();
            double value = 0;
            int counter = 0;
            foreach (Product element in MyList)
            {
                if(MyType.Equals(element.Gettype))
                {
                    value = (element.GetPrice * element.GetQuantity);
                    counter++;
                }
            }
            Console.WriteLine(value / counter);
        }
    }
}
