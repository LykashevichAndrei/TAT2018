using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2task
{
    class Program
    {
        static void Main(string[] args)
        {
            long ageaOfRectangle;
            Rectangle rectangle = new Rectangle();
            ageaOfRectangle = rectangle.CalculateArea(args[0], args[1]);
        }
    }
}
