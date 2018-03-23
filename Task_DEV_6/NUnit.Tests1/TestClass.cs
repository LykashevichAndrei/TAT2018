using NUnit.Framework;
using System.Collections.Generic;
using Task_DEV_6;

namespace Task_DEV_6
{
    [TestFixture]
    public class TestClass
    {
        [TestCase("pencil", 3)]
        public void TestAveragePriceCalc(string TestName, double price)
        {
            Product temp = new Product();
            List<Product> list = new List<Product>();
            list.Add(new Product("pencil", "arct", 12, 1.35));
            AveragePriceWithType APWT = new AveragePriceWithType(list);
            double CheckResult = APWT.Calculate();
            Assert.AreEqual(CheckResult, price);
        }
        [TestCase(12)]
        public void TestCountAll(double all)
        {
            Product temp = new Product();
            List<Product> list = new List<Product>();
            list.Add(new Product("pencil", "arct", 12, 1.35));
            CountAll CA = new CountAll(list);
            double CheckResult = CA.Calculate();
            Assert.AreEqual(CheckResult, all);
        }
        [TestCase(12)]
        public void TestAveragePrice(double all)
        {
            Product temp = new Product();
            List<Product> list = new List<Product>();
            list.Add(new Product("pencil", "arct", 12, 1.35));
            CountAll CA = new CountAll(list);
            double CheckResult = CA.Calculate();
            Assert.AreEqual(CheckResult, all);
        }
        [TestCase(2)]
        public void TestCountTypes(double all)
        {
            Product temp = new Product();
            List<Product> list = new List<Product>();
            list.Add(new Product("pencil", "arct", 12, 1.35));
            list.Add(new Product("pencil", "arct", 12, 1.35));
            list.Add(new Product("pencl", "arct", 12, 1.35));
            CountTypes CT = new CountTypes(list);
            double CheckResult = CT.Calculate();
            Assert.AreEqual(CheckResult, all);
        }
    }
}
