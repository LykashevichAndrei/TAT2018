﻿using System;

namespace TASK_DEV_7
{
    /// <summary>
    /// class of car we want to buy
    /// </summary>
    public class EnteredCar : Car
    {
        public EnteredCar()
        {
            Console.WriteLine("Enter mark");
            mark = Console.ReadLine();
            Console.WriteLine("Enter model");
            model = Console.ReadLine();
            Console.WriteLine("Type of car body");
            bodytype = Console.ReadLine();
            Console.WriteLine("Transmission Type");
            transmissiontype = Console.ReadLine();
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

