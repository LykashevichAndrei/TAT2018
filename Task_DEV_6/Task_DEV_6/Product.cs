using System;
using System.Threading;
using System.Globalization;

namespace Task_DEV_6
{
    /// <sumary>
    /// Class describing the product
    /// </sumary>
    public class Product
    {
        string type;
        string name;
        int quantity;
        double price;

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Product()
        {
            Console.WriteLine("Enter the type");
            this.type = Console.ReadLine();
            Console.WriteLine("Enter the name");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter the quantity");
            this.quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price");
            this.price = Converter(Console.ReadLine());
        }
        public Product(string type, string name, int quantity, double price)
        {
            this.type = type;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
        private double Converter(string InputString)
        {
            CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            double result = double.Parse(InputString);
            Thread.CurrentThread.CurrentCulture = temp_culture;
            return result;
        }
        public string Gettype
        {
            get
            {
                return type;
            }
        }
        public string GetName
        {
            get
            {
                return name;
            }
        }
        public int GetQuantity
        {
            get
            {
                return quantity;
            }
        }
        public double GetPrice
        {
            get
            {
                return price;
            }
        }
    }
}
