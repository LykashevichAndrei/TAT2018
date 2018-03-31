using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace TASK_DEV_7
      {/// <summary>
       /// Class deserializing JSON File
       /// </summary>
     public class JSONDeserialize
    {
        private string way;
        public JSONDeserialize(string Way)
        {
            this.way = Way;
        }
        /// <summary>
        /// desirealizing JSon
        /// </summary>
        /// <returns>List Cars</returns>
        public List<Car> Deserialize()
        {
            using (FileStream stream = File.OpenRead(way))
            {
                List<Type> types = new List<Type>();
                types.Add(typeof(BMW));
                types.Add(typeof(Tesla));
                types.Add(typeof(Opel));
                DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(List<Car>), types);
                List<Car> cars = (List<Car>)deserializer.ReadObject(stream);
                return cars;
            }
        }
    }
}
