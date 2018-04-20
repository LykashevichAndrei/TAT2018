using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task19_04
{
    delegate float calculate(List<int> x, List<int> y);
    class Program
    {
        static void Main(string[] args)
        {
            List<int> FirstVector = new List<int>();
            List<int> SecondVector = new List<int>();
            VectorCreator createVector = new VectorCreator();
            FirstVector = createVector.CreateRandVector();
            SecondVector = createVector.CreateRandVector();
            SizeCalculator calculator = new SizeCalculator();
            CalcMethods calc = new CalcMethods();
            float size=0;
            Console.WriteLine("1-universal");
            Console.WriteLine("2-Cartesian coordinates");
            int temp=Convert.ToInt32(Console.ReadLine());
            switch (temp)
            {
                case 1:
                    {
                        calculate del = new calculate(calc.CalculateLength);
                        size = calculator.Calculate(FirstVector,SecondVector,del);
                        break;
                    }
                case 2:
                    {
                        calculate del = new calculate(calc.CalculateDistance);
                        size = calculator.Calculate(FirstVector, SecondVector, del);
                        break;
                    }
            }
            Console.WriteLine(size);
            Console.ReadLine();
        }

    }
}
