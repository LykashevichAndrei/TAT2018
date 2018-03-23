using System;
using System.Collections.Generic;

namespace Task_DEV_6
{
    /// <summary>
    /// class that counts the value of one type
    /// </summary>
    class AveragePrice : ICalculate
    {
        private List<Product> MyList;
        public AveragePrice(List<Product> products)
        {
            this.MyList = products;
        }
        /// <summary>
        /// counts the value of one type
        /// </summary>
        public double Calculate()
        {
            int counter = 0;
            double value = 0;
            foreach (Product element in MyList)
            {
                value += (element.GetPrice * element.GetQuantity);
                counter += element.GetQuantity;
            }
            return (value / counter);
        }
    }
}
