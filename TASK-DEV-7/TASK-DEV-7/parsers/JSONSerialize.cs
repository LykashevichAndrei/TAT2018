using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TASK_DEV_7
{
    class JSONSerialize
    {
        public void Serialize(Car addcar,List<Car> Addhere)
        {
            StringBuilder stock = new StringBuilder();
            stock.Append(JsonConvert.SerializeObject(addcar));
            foreach(Car elements in Addhere)
            {
                stock.Append(JsonConvert.SerializeObject(elements));
            }
        }
    }
}
