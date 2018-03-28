using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_DEV_7
{
    class TeslaCarCreate
    {
        string mark;
        string model;
        string bodytype;
        string transmissiontype;
        string enginetype;
        double amount;
        int power;
        string climate;
        string carinterior;
        string quantity;

        public TeslaCarCreate(string Model, string BodyType, string TransmissionType, string EngyneType, double Amount, int Power, string Climate, string CarInterior)
        {
           this.model = Model;
           this.bodytype = BodyType;
           this.transmissiontype = TransmissionType;
           this.enginetype = EngyneType;
           this.amount = Amount;
           this.power = Power;
           this.climate = Climate;
           this.carinterior = CarInterior;
        }
    }
}
