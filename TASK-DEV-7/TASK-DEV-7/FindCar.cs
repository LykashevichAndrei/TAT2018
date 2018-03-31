using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TASK_DEV_7
{
    /// <summary>
    /// Class To Find Car to buy
    /// </summary>
    class FindCar
    {
        List<Car> catalog;
        EnteredCar enteredCar;
        public FindCar(List<Car> ThereIs,EnteredCar Want)
        {
            try
            {
                this.catalog = ThereIs;
                this.enteredCar = Want;
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Catalog or your entered car is empty");
            }
        }
        /// <summary>
        /// method that find suitable car
        /// </summary>
        /// <returns>number of suitable car in our list</returns>
        public int Find()
        {
           var result = from el in catalog
                                      where (el.bodytype == enteredCar.bodytype || el.bodytype == string.Empty)
                                      && (el.transmissiontype == enteredCar.transmissiontype || el.transmissiontype == string.Empty)
                                      && (el.enginetype == enteredCar.enginetype || el.enginetype == string.Empty) 
                                      && (el.amount == enteredCar.amount || el.amount == string.Empty) 
                                      && (el.power == enteredCar.power || el.power == string.Empty) 
                                      && (el.climate == enteredCar.climate || el.climate == string.Empty) 
                                      && (el.carinterior == enteredCar.carinterior || el.carinterior == string.Empty)
                                      select el;
            int i = 0;
            foreach(Car elements in result)
            {
                Console.Write(i+"-");
                Console.WriteLine(elements);
                i++;
            }

            if(result != null)
            {
                return 0;
            }
            else
            {
                return i;
            }
        }
    }
}
