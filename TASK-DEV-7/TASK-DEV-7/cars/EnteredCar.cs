using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TASK_DEV_7
{
    class EnteredCar :Car
    {
        
       /* private string mark;
        private string model;
        private string bodytype;
        private string transmissiontype;
        private string enginetype;
        private double amount;
        private double power;
        private string climate;
        private string carinterior;*/

        public EnteredCar()
        {
            Console.WriteLine("Enter mark");
            mark = Console.ReadLine();
            Console.WriteLine("Enter model");
            model = Console.ReadLine();
            Console.WriteLine("Type of car body");
            Console.WriteLine("1-station wagon");
            Console.WriteLine("2-sedan");
            Console.WriteLine("3-minivan");
            Console.WriteLine("4-compartment");
            string TempBody;
            TempBody = Console.ReadLine();
            switch (TempBody)
            {
                case "1":
                    bodytype = "StationWagon";
                    break;
                case "2":
                    bodytype = "Sedan";
                    break;
                case "3":
                   bodytype = "minivan";
                    break;
                case "4":
                    bodytype = "compartment";
                    break;
                default:
                    Console.WriteLine("invalid type of parameters entered");
                    break;
            }
            Console.WriteLine("enter the transmission type");
            Console.WriteLine("1-automatic ");
            Console.WriteLine("2-manual gearbox");
            string CarTransmission;
            CarTransmission = Console.ReadLine();
            switch (CarTransmission)
            {
                case "1":
                    transmissiontype = "Automatic";
                    break;
                case "2":
                    transmissiontype = "Manual";
                    break;
                default:
                    Console.WriteLine("invalid type of parameters entered");
                    break;
            }
            Console.WriteLine("enter the engine type");
            Console.WriteLine("1-petrol");
            Console.WriteLine("2-diesel");
            Console.WriteLine("3-electro");
            string CarEngine;
            CarEngine = Console.ReadLine();
            switch (CarEngine)
            {
                case "1":
                    enginetype = "petrol";
                    break;
                case "2":
                    enginetype = "diesel";
                    break;
                case "3":
                    enginetype = "electro";
                    break;
                default:
                    Console.WriteLine("invalid type of parameters entered");
                    break;
            }
            Console.WriteLine("Enter engine capacity");
            amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter engine power");
            power = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the climate management");
            Console.WriteLine("1-climate control");
            Console.WriteLine("2-condition");
            Console.WriteLine("3-car without climate management ");
            string CarClimate;
            CarClimate = Console.ReadLine();
            switch (CarClimate)
            {
                case "1":
                    climate = "СlimateСontrol";
                    break;
                case "2":
                    climate = "condition";
                    break;
                case "3":
                    climate = "";
                    break;
                default:
                    Console.WriteLine("invalid type of parameters entered");
                    break;
            }
            if (transmissiontype == "Automatic")
            {
                carinterior = "leather";
            }
            else
                Console.WriteLine("enter type of car interior");
            Console.WriteLine("1-leather interior");
            Console.WriteLine("2-fabric salon");
            Console.WriteLine("3-combined salon");
            string CarSalon;
            CarSalon = Console.ReadLine();
            switch (CarSalon)
            {
                case "1":
                    carinterior = "leather";
                    break;
                case "2":
                    carinterior = "fabric";
                    break;
                case "3":
                    carinterior = "combined";
                    break;
                default:
                    Console.WriteLine("invalid type of parameters entered");
                    break;
            }
        }
    }
}

