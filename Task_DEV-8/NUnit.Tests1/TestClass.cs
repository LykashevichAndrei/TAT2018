using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_DEV_8;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [TestCase(12)]
        public void AverageAgeTest(double result)
        {
            List<User> users = new List<User>();
            users.Add(new User("a", "aa", "M", 13));
            users.Add(new User("b", "bb", "W", 12));
            users.Add(new User("c", "cc", "M", 14));
            ComandeExecutor test1 = new ComandeExecutor();
            double res = test1.AverageAge(users);
            Assert.Equals(res, result);
        }
        public void OldestUsersTest()
        {
            User result = new User("Oldest", "User", "M", 100);
            List<User> users = new List<User>();
            users.Add(result);
            users.Add(new User("aa", "a", "M", 2));
            users.Add(new User("bb", "b", "M", 22));
            users.Add(new User("cc", "c", "M", 5));
            users.Add(new User("dd", "d", "M", 33));
            ComandeExecutor test2 = new ComandeExecutor();
            User rez = test2.OldestUser(users);
            Assert.Equals(result, rez);
        }
    }
}
