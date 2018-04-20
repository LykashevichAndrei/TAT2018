using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task19_04
{
    class CalcMethods
    {
        public float CalculateLength(List<int> x, List<int> y)
        {
            float result = 0;
            int length = x.Count;
            for (int i = 0; i < length; i++)
            {
                result += x[i] ^ 2 - y[i] ^ 2;
            }
            return result;
        }
        public float CalculateDistance(List<int> x, List<int> y)
        {
            float result = 0;
            int length = x.Count;
            for (int i = 0; i < length; i++)
            {
                result += x[i] ^ 2 - y[i] ^ 2;
            }
            Math.Pow(result, 0.5);
            return result;
        }
    }
}
