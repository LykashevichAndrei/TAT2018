using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_DEV_7
{
    class TeslaCar : ICar
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

        public TeslaCar(string Model, string BodyType, string TransmissionType, string EngyneType, double Amount, int Power, string Climate , string CarInterior)
        {
           model = Model;
           bodytype = BodyType;
           transmissiontype = TransmissionType;
           enginetype = EngyneType;
           amount = Amount;
           power = Power;
           climate = Climate;
           carinterior = CarInterior;
        }
    }  
}
