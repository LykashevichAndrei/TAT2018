using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Task_DEV_8
{
    class ComandeExecutor
    {
        public double AverageAge(List<User> users)
        {
            int ages=0;
            int numberofusers=0;
            foreach (User element in users)
            {
                ages += element.Age;
                numberofusers++;
            }
            double averageage = ages / numberofusers;
            return averageage;
        }
        public User OldestUser(List<User> users)
        {
            var result = users.OrderByDescending(x => x.Age).First(); 
            User OldestUser = result;
            return OldestUser;
        }
        public string GetPopularFemaleName(List<User> users)
        {
            List<string> GirlsNames = new List<string>();
            foreach (User el in users)
            {
                if (el.Sex.Equals("W"))
                {
                    GirlsNames.Add(el.FirstName);
                }
            }
            var most = GirlsNames.GroupBy(x => x).OrderByDescending(x => x.Count()).First();
            string name = most.Key;
            return name;
        }
    }
}
