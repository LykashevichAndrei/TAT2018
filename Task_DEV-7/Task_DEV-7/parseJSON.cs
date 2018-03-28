using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Task_DEV_7
{
    class parseJSON
    {
        public string mark { get; set; }
        public string model { get; set; }
        public string bodytype { get; set; }
        public string transmissiontype { get; set; }
        public string enginetype { get; set; }
        public double amount { get; set; }
        public int power { get; set; }
        public string climate { get; set; }
        public string carinterior { get; set; }
        public string quantity { get; set; }
    }
}
