using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] Cars = new Car[3];
            Cars[0] = new Car("agila", "Opel");
            Cars[1] = new Car("T1", "Tesla");
            Cars[2] = new Car("polo", "VW");
            AutoHouse CarList = new AutoHouse(Cars);
            Console.WriteLine("ALL Cars");
            foreach (Car el in CarList)
            {
                Console.WriteLine(el.company + " " + el.model);
            }
            Console.WriteLine("UNIQUE Cars");

            Console.ReadLine();
        }
    }
}
