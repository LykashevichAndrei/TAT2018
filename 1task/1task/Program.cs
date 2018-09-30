using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            Console.WriteLine("And hi again!");
            int n = new int();
            Random rarnNumber = new Random();
            n = rarnNumber.Next(5, 50);
            StringBuilder lastString = new StringBuilder();
            for(int i=0;i<n;i++)
            {
                lastString.Append("!");
            }
            Console.WriteLine(lastString);
        }
    }
}
