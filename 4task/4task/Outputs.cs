using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4task
{
    class Outputs
    {
        public void outputPeoples(List<Peoples> peoples)
        {
            foreach(Peoples element in peoples)
            {
                Console.WriteLine(element.name+" " + element.lastname+" " + element.age);
            }
        }
        public void outputAges(List<Peoples> peoples)
        {
            List<double> ages = new List<double>();
            foreach(Peoples el in peoples)
            {
                ages.Add(el.age);
            }
            double maxage=0;
            foreach (double el in ages)
            {
                if (el > maxage)
                    maxage = el;
            }
            double minage=maxage;
            foreach (double el in ages)
            {
                if (el < minage)
                    minage = el;
            }
            double averageage=0;
            int temp = 0;
            foreach (double el in ages)
            {
                temp++;
                averageage += el;
            }
            averageage = averageage / temp;
            Console.WriteLine(minage+" " + maxage+" " + Math.Round(averageage, 2));
        }
    }
}
