using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TASK_DEV_7
{
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
        public bool Find()
        {
           var result = from el in catalog
                                      where (el.bodytype == enteredCar.bodytype || el.bodytype == string.Empty) && (el.transmissiontype == enteredCar.transmissiontype || el.transmissiontype == string.Empty) && (el.enginetype == enteredCar.enginetype || el.enginetype == string.Empty) &&
                                      (el.amount == enteredCar.amount || el.amount == 0) && (el.power == enteredCar.power || el.power == 0) && (el.climate == enteredCar.climate || el.climate == string.Empty) && (el.carinterior == enteredCar.carinterior || el.carinterior == string.Empty)
                                      select el;
            Console.WriteLine(result);     
            if(result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
