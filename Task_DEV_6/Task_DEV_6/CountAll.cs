﻿using System;
using System.Collections.Generic;

namespace Task_DEV_6
{
    /// <summary>
    /// class counting the number of products
    /// </summary>
    class CountAll : ICalculate
    {
        private List<Product> MyList;
        public CountAll(List<Product> products)
        {
            this.MyList = products;
        }
        /// <summary>
        /// counting the number of products
        /// </summary>
        public void Calculate()
        {
            int quantityofgoods=0;
            foreach (Product element in MyList)
            {
                        quantityofgoods+= element.GetQuantity;
            }
            Console.WriteLine(quantityofgoods);
        }
    }
}
