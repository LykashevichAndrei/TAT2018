using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TASK_DEV_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Car you want");

            EnteredCar enteredCar = new EnteredCar();
            List<Car> carcatalog = new List<Car>();
            JSONDeserialize catalog = new JSONDeserialize(@args[0]);
            carcatalog=catalog.Deserialize();
            List<Car> stockcatalog = new List<Car>();
            JSONDeserialize carsinstock = new JSONDeserialize(@args[1]);
            stockcatalog = carsinstock.Deserialize();
            FindCar FK = new FindCar(carcatalog,enteredCar);
            bool stockavailability;
            stockavailability= FK.Find();
            Console.ReadLine();
        }
    }
}
