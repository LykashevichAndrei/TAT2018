using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_DEV_8
{
    delegate void ADDSimilarUser();
    class AddUser
    {
        public delegate void MethodContainer(User x);
        public event MethodContainer onCount;
        public User Add(List<User> users)
        {
            Console.WriteLine("Enter name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter surname");
            string secondname = Console.ReadLine();
            Console.WriteLine("M/W");
            string sex = Console.ReadLine(); ;
            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine()); 
            foreach (User element in users)
            {
                if(secondname.Equals(element.LastName))
                {
                    onCount(element);
                }
            }
            User UsertoAdd = new User(name,secondname,sex,age);
            return UsertoAdd;
        }

    }
}
