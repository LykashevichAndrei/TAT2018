using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TASK_DEV_7
{
    /// <summary>
    /// entery point
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Car you want");

            EnteredCar enteredCar = new EnteredCar();
            List<Car> carcatalog = new List<Car>();
            JSONDeserialize catalog = new JSONDeserialize(args[0]);
            carcatalog=catalog.Deserialize();
            foreach (Car elements in carcatalog)
            {
                Console.WriteLine(elements);
            }
            List<Car> stockcatalog = new List<Car>();
            JSONDeserialize carsinstock = new JSONDeserialize(args[1]);
            stockcatalog = carsinstock.Deserialize();
            FindCar FK = new FindCar(stockcatalog,enteredCar);
            int stockavailability;
            stockavailability= FK.Find();
            if(stockavailability==0)
            {
                int catalogavailability = 0;
                FindCar FC = new FindCar(carcatalog, enteredCar);
                catalogavailability = FC.Find();
                if(catalogavailability==0)
                {
                    Console.WriteLine("there is no such car in the catalog");
                }
                else
                {
                    Console.WriteLine("the order went to the warehouse");
                    JSONSerialize serialize = new JSONSerialize();
                    serialize.Serialize(carcatalog[catalogavailability],stockcatalog);
                }
            }
            if(stockavailability !=0)
            {
                Console.WriteLine("car is in stock");
                stockcatalog[stockavailability].quantity -= 1;
            }
            Console.ReadLine();
        }
    }
}
