using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2task
{
    [TestFixture]
    public class TestClass1
    {
        [TestCase(0, 0,0)]
        [TestCase(-3, 2,0)]
        [TestCase(221, "ewww",0)]
        [TestCase(221, 1, 221)]
        public void CalculateAreaTest(string length,string width,long result)
        {
            Rectangle rectangle = new Rectangle();
           long Reault= rectangle.CalculateArea(length, width);
            Assert.Equals(Reault, result);
        }
    }
}
