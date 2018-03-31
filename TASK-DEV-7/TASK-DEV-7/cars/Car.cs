using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TASK_DEV_7
{
    abstract class Car : Object
    {
        public string mark { get; set; }
        public string model { get; set; }
        public string bodytype { get; set; }
        public string transmissiontype { get; set; }
        public string enginetype { get; set; }
        public string amount { get; set; }
        public string power { get; set; }
        public string climate { get; set; }
        public string carinterior { get; set; }
        public int quantity { get; set; }
    }
}
