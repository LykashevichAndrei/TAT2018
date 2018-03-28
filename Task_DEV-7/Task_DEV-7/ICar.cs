using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_DEV_7
{
    interface ICar
    {
        string mark { get; set; }
        string model { get; set; }
        string bodytype { get; set; }
        string transmissiontype { get; set; }
        string enginetype { get; set; }
        double amount { get; set; }
        int power { get; set; }
        string climate { get; set; }
        string carinterior { get; set; }
        string quantity { get; set; }
    }
}
