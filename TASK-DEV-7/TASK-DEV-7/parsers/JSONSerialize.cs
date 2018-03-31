using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace TASK_DEV_7
{
    /// <summary>
    /// Serialize Json File
    /// </summary>
    class JSONSerialize
    {
        /// <summary>
        /// Method that serialize our list to JSON
        /// </summary>
        /// <param name="addcar">Car We Want to add to File</param>
        /// <param name="Addhere">List With Cars</param>
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
