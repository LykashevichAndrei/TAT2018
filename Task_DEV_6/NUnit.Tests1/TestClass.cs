using NUnit.Framework;
using System.Collections.Generic;
using Task_DEV_6;

namespace Task_DEV_6
{
    [TestFixture]
    public class TestClass
    {
        [TestCase("pencil",3)]
        public void TestAveragePriceCalc(string TestName,double price)
        {
            Product list = new Product();
            list.Add(new Product("pencil", "arct",12,1.35));
            AveragePriceWithType APWT = new AveragePriceWithType(list);
            double CheckResult = APWT.Calculate();
            Assert.AreEqual(CheckResult, price);
        }
    }
}
