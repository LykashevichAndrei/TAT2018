using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_DEV_8
{
    class MainMenu
    {
        List<User> users=new List<User>();
        public void ADD()
        {
            AddUser adduser = new AddUser();
            SimilarUsers folover = new SimilarUsers();
            adduser.onCount += folover.Write;
            User added;
            Console.WriteLine("How many users do you want to add?");
            int numberofnewusers;
            numberofnewusers = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberofnewusers; i++)
            {
               added= adduser.Add(users);
               users.Add(added);
            }
        }
        public void GetComand()
        {
            ComandeExecutor executor = new ComandeExecutor();
            Console.WriteLine("available commands:");
            Console.WriteLine("1) average age");
            Console.WriteLine("2) oldest user");
            Console.WriteLine("3) the most popular female name or press 3");
            string Comand=Console.ReadLine();
            double averageage;
            User oldestuser;
            string MostPopularFemaleName;
            switch (Comand)
            {
                case "average age":
                    averageage=executor.AverageAge(users);
                    Console.WriteLine(averageage);
                    break;
                case "oldest user":
                    oldestuser = executor.OldestUser(users);
                    Console.WriteLine(oldestuser.FirstName+" "+oldestuser.LastName+" "+oldestuser.Age);
                    break;
                case "the most popular female name":
                    MostPopularFemaleName = executor.GetPopularFemaleName(users);
                    Console.WriteLine(MostPopularFemaleName);
                    break;
                case "3":
                    MostPopularFemaleName = executor.GetPopularFemaleName(users);
                    Console.WriteLine(MostPopularFemaleName);
                    break;
            }
        }
    }
}
