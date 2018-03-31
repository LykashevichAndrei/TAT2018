using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TASK_DEV_7.creators;

namespace TASK_DEV_7
      {/// <summary>
       /// 
       /// </summary>
    class JSONDeserialize
    {
        private string way;
        public JSONDeserialize(string Way)
        {
            this.way = Way;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Car> Deserialize()
        {
            string jsontostring = File.ReadAllText(@way);
            List<Car> result = new List<Car>();
            int n = FindTheNumberOfElementsInJSON(jsontostring);
            StringBuilder[] objects=new StringBuilder[n];
            for(int i=0;i<n;i++)
            {
                int startposition=jsontostring.IndexOf("{");
                int endposition = jsontostring.IndexOf("}");
                for(int j=startposition;j<=endposition;j++)
                {
                    objects[i].Append(jsontostring[j]);
                    objects[i].Remove(jsontostring[j],1);
                }
                Car m = JsonConvert.DeserializeObject<Car>(objects[i].ToString());
                switch (m.mark)
                { 
                case"Tesla":
                        TeslaCreator tesla = new TeslaCreator();
                        
                        result.Add(tesla.Create(m.mark, m.model, m.bodytype, m.transmissiontype, m.enginetype, m.amount, m.power, m.climate, m.carinterior));
                        break;
                case "BMW":
                        BMWCreator bmw = new BMWCreator();
                        result.Add(bmw.Create(m.mark, m.model, m.bodytype, m.transmissiontype, m.enginetype, m.amount, m.power, m.climate, m.carinterior));
                        break;
                case "Opel":
                        OpelCreator opel = new OpelCreator();
                        result.Add(opel.Create(m.mark, m.model, m.bodytype, m.transmissiontype, m.enginetype, m.amount, m.power, m.climate, m.carinterior));
                        break;
                }
            }
            return result;
        }

        private int FindTheNumberOfElementsInJSON(string jsontostring)
        {
            int b=0;
            for (int i = 0; i < jsontostring.Length; i++)
            {
                if (jsontostring[i].Equals("}") == true)
                {
                    b++;
                }
            }
            return b;
        }
    }
}
