using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task19_04
{
    class VectorCreator
    {
        public List<int> CreateRandVector()
        {
            Random rand = new Random();
            List<int> Vector = new List<int>();
            //Console.WriteLine("enter a range of values");
            //int min = Convert.ToInt32(Console.ReadLine());
            //int max = Convert.ToInt32(Console.ReadLine());
            int VectorSize = rand.Next(3, 3);
            for(int i=0;i<VectorSize;i++)
            {
                Vector.Add(rand.Next());
            }
            return Vector;
        }
        public List<int> CreateManual()
        {
            List<int> vector = new List<int>();
            Console.WriteLine("enter size of vector");
            int VectorSize= Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<VectorSize;i++)
            {
                vector.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return vector;
        }
    }
}
