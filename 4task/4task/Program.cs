using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4task
{
    class Program
    {
        static void Main(string[] args)
        {
            bool temp=true;
            List<Peoples> peoples = new List<Peoples>();
            do
            {
                peoples.Add(new Peoples());
                Console.WriteLine("press 1 to add new person");
                Console.WriteLine("press 0 to continue");
                int tmp = Convert.ToInt32(Console.ReadLine());
                if (tmp == 1)
                    temp = true;
                else
                    temp = false;
            }
            while (temp == true);
            Outputs output = new Outputs();
            output.outputPeoples(peoples);
            output.outputAges(peoples);
            Console.ReadLine();
        }
    }
}
