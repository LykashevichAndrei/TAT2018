using NUnit.Framework;
using task_DEV_3;

namespace task_DEV_3
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(255, 16, "FF")]
        [TestCase(10, 2, "0101")]
        [TestCase(20, 20, "01")]
        public void calculatenewsystemtest(int number, int numbersystem, string result)
        {
            NewNumberSysteminterpreter test1 = new NewNumberSysteminterpreter(number, numbersystem);
            string newstr = test1.calculatenewsystem();
            Assert.AreEqual(result, newstr);
        }
        [TestCase("1001", "1001")]
        [TestCase("100", "001")]
        [TestCase("abcd", "dcba")]
        public void ReverseAnswerTest(string input,string output)
        {
            NewNumberSysteminterpreter test2 = new NewNumberSysteminterpreter(10, 10);
            string temp = test2.ReverseAnswer(input);
            Assert.AreEqual(temp, output);
        }

    }
}

