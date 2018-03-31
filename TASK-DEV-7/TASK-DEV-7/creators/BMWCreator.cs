using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TASK_DEV_7.creators
{
    class BMWCreator:ICreate
    {
        public Car Create(string Mark, string Model, string Bodytype, string Transmissiontype, string Enginetype, string Amount, string Power, string Climate, string Carinterior)
        {
            return new BMW(Mark, Model, Bodytype, Transmissiontype, Enginetype, Amount, Power, Climate, Carinterior);
        }
    }
}
