using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_DEV_7
{
    class DesiredCar
    {
        private string mark;
        private string model;
        private string bodytype;
        private string transmissiontype;
        private string enginetype;
        private double amount;
        private double power;
        private string climate;
        private string carinterior;

        public DesiredCar()
        {
            Console.WriteLine("Enter mark");
            this.mark = Console.ReadLine();
            Console.WriteLine("Enter model");
            this.model = Console.ReadLine();
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
                    this.bodytype = "StationWagon";
                    break;
                case "2":
                    this.bodytype = "Sedan";
                    break;
                case "3":
                    this.bodytype = "minivan";
                    break;
                case "4":
                    this.bodytype = "compartment";
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
                    this.transmissiontype = "Automatic";
                    break;
                case "2":
                    this.transmissiontype = "Manual";
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
                    this.enginetype = "petrol";
                    break;
                case "2":
                    this.enginetype = "diesel";
                    break;
                case "3":
                    this.enginetype = "electro";
                    break;
                default:
                    Console.WriteLine("invalid type of parameters entered");
                    break;
            }
            Console.WriteLine("Enter engine capacity");
            this.amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter engine power");
            this.power = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the climate management");
            Console.WriteLine("1-climate control");
            Console.WriteLine("2-condition");
            Console.WriteLine("3-car without climate management ");
            string CarClimate;
            CarClimate = Console.ReadLine();
            switch (CarClimate)
            {
                case "1":
                    this.climate = "СlimateСontrol";
                    break;
                case "2":
                    this.climate = "condition";
                    break;
                case "3":
                    this.climate = "";
                    break;
                default:
                    Console.WriteLine("invalid type of parameters entered");
                    break;
            }
            if (this.transmissiontype == "Automatic")
            {
                this.carinterior = "leather";
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
                    this.climate = "leather";
                    break;
                case "2":
                    this.climate = "fabric";
                    break;
                case "3":
                    this.climate = "combined";
                    break;
                default:
                    Console.WriteLine("invalid type of parameters entered");
                    break;
            }
        }
    }
}
