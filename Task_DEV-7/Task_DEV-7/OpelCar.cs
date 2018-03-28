using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_DEV_7
{
    class OpelCar : ICar
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

        public OpelCar(string Model, string BodyType, string TransmissionType, string EngyneType, double Amount, int Power, string Climate, string CarInterior)
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
