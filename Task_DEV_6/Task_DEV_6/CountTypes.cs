using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_DEV_6
{
    /// <summary>
    /// class counting the number of product types
    /// </summary>
    public class CountTypes : ICalculate
    {
        private List<Product> MyList;
        public CountTypes(List<Product> products)
        {
            this.MyList = products;
        }
        /// <summary>
        /// counting the number of product types
        /// </summary>
        public double Calculate()
        {
            int numberoftypes = 0;
            List<Product> uniq = new List<Product>();
            uniq.AddRange(MyList.Distinct());
            foreach (Product element in uniq)
            {
                numberoftypes++;
            }
            return (numberoftypes);
        }
    }
}
