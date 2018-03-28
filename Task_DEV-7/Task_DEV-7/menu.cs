using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using System.Linq;

namespace Task_DEV_7
{
    class menu
    {
        public void mainmenu(string way)
        {
            Console.WriteLine("Enter parameters");
            DesiredCar car = new DesiredCar();
            List<DesiredCar> want = new List<DesiredCar>();
            want.Add(car);
            List<Car> CarCatalog = new List<Car>();
            var data = JsonConvert.DeserializeObject<List<parseJSON>>(way);//.OrderByDescending(x => x.Score).ToList()
            
            data.ForEach(player =>
            {
                if(parseJSON.get.mark=="Tesla")
                CarCatalog.Add(new TeslaCar(parseJSON.model, parseJSON.bodytype, parseJSON.transmissiontype, parseJSON.enginetype, parseJSON.amount, parseJSON.power, parseJSON.climate, parseJSON.carinterior));
                if (data.parseJSON.mark == "Opel")
                    CarCatalog.Add(new OpelCar(parseJSON.model, parseJSON.bodytype, parseJSON.transmissiontype, parseJSON.enginetype, parseJSON.amount, parseJSON.power, parseJSON.climate, parseJSON.carinterior));
            });
        }
    }
}
