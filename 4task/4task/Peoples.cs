using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4task
{
    class Peoples
    {
        public string name;
        public string lastname;
        public double age;
        public Peoples()
        {
            this.name = Console.ReadLine();
            this.lastname = Console.ReadLine();
            this.age = Convert.ToInt32(Console.ReadLine());
        }
    }
}
