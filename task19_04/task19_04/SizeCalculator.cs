using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task19_04
{
    class SizeCalculator
    {
        public float Calculate(List<int > FirstVector, List<int> SecondVector, calculate del)
        {
            float length=0;
            if(FirstVector.Count!=SecondVector.Count)
            {
                Console.WriteLine("the length of the vectors does not match");
            }
            else
            {
                length = del(FirstVector,SecondVector);
            }
            return length;
        }
    }
}
