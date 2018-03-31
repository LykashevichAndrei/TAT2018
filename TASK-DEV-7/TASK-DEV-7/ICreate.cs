using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TASK_DEV_7
{
    public interface ICreate
    {
        Car Create(string Mark, string Model, string Bodytype, string Transmissiontype, string Enginetype, string Amount, string Power, string Climate, string Carinterior);
    }
}
