﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TASK_DEV_7
{
    class Tesla:Car
    {
       public Tesla(string Mark, string Model, string Bodytype, string Transmissiontype, string Enginetype, string Amount, string Power, string Climate, string Carinterior)
        {
            model = Model;
            mark = Mark;
            bodytype = Bodytype;
            transmissiontype = Transmissiontype;
            enginetype = Enginetype;
            amount = Amount;
            power = Power;
            climate = Climate;
            carinterior = Carinterior;
        }
    }
}