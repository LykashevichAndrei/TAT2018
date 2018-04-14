using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_DEV_8
{
    class User
    {
        public string FirstName;
        public string LastName;
        public string Sex;
        public int Age;
        public User()
        {
            Console.WriteLine("Enter name");
            this.FirstName = Console.ReadLine();
            Console.WriteLine("Enter surname");
            this.LastName = Console.ReadLine();
            Console.WriteLine("M/W");
            this.Sex = Console.ReadLine();
            Console.WriteLine("Enter age");
            this.Age = Convert.ToInt32(Console.ReadLine());
        }
        public User(string name,string secondname,string sex,int age)
        {
            this.FirstName = name;
            this.LastName = secondname;
            this.Sex = sex;
            this.Age = age;
        }
    }
}
