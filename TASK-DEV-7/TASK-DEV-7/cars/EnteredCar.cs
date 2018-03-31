using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TASK_DEV_7
{
    class EnteredCar :Car
    {
        public EnteredCar()
        {
            Console.WriteLine("Enter mark");
            mark = Console.ReadLine();
            Console.WriteLine("Enter model");
            model = Console.ReadLine();
            Console.WriteLine("Type of car body");
            bodytype= Console.ReadLine();
            Console.WriteLine("Transmission Type");
            transmissiontype= Console.ReadLine();
            Console.WriteLine("Engin Type");
            enginetype = Console.ReadLine();
            Console.WriteLine("Amount");
            amount = Console.ReadLine();
            Console.WriteLine("Power");
            power = Console.ReadLine();
            Console.WriteLine("Climate control");
            climate = Console.ReadLine();
            Console.WriteLine("car interior");
            carinterior = Console.ReadLine();
        }
    }
}

