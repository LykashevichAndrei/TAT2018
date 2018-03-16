//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Text;
using task_DEV_3;

namespace task_DEV_3
{
    [TestFixture]
    public class TestNewNumberSystemConverter
    {
        
        [TestCase(255, 16, "FF")]
        [TestCase(10, 2, "101")]
        [TestCase(20, 20, "1")]
        [Test]
        public void calculatenewsystemtest(int number, int NumberSystem, string Result)
        {
            NewNumberSysteminterpreter test1 = new NewNumberSysteminterpreter(number, NumberSystem);
            string check = test1.calculatenewsystem();
            Assert.AreEqual(check, Result);
        }
       
        [TestCase("1101", "1011")]
        [TestCase("1111", "1111")]
        [TestCase("1000", "1")]
        [Test]
        public void ReverseAnswerTest(string input, string output)
        {
            NewNumberSysteminterpreter test2 = new NewNumberSysteminterpreter(10, 10);
            string StringReverse;
            StringReverse = test2.ReverseAnswer(input);
            Assert.AreEqual(StringReverse, output);
        }
    }
}