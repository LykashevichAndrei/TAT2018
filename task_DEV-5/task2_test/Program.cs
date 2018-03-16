using System;
using System.Text;

namespace task_DEV_2
{
    /// <summary>
    /// The entry point to the program.
    /// </summary>
    class EnteryPoint
    {
        static void Main()
        {
            string newstring;
            newstring = Console.ReadLine();
            EvenElementsOfTheString mystring = new EvenElementsOfTheString(newstring);
            string str = mystring.FindingEvenElemenstInString();  //We assign the even values ​​of the string to the variable
            Console.WriteLine(str);
        }
    }
}