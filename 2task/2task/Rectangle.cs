using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2task
{
    class Rectangle
    {
        public long CalculateArea(string Length,string Width)
        {
            long result=0;
            try
            {
                int length = Int32.Parse(Length);
                int width = Int32.Parse(Width);
                result = length * width;
                return result;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("one or two of the arguments are zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid input format");
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("You entered a large number");
            }
            return result;
        }
    }
}
