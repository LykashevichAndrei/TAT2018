using NUnit.Framework;
using Task_DEV_11;

namespace ClientConsole
{
    [TestFixture]
    public class TestClass
    {
        [TestCase(0, 0, 0, 0 )]
        [TestCase(0, 1, 1, 32)]
        [TestCase(1, 0, 1, 366)]
        [TestCase(0, 1, 0, 31)]
        public void CountThePastNumberOfDaysTest_ValidValues(int day, int month, int year, int result)
        {
            Server webServis = new Server();
            int days = webServis.GetDaysFromChristsBirthday(year, month, day);
            Assert.AreEqual(result,days);
        }
    }
}
