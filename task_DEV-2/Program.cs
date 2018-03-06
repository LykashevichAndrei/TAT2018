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
                EvenElementsOfTheString mystring = new EvenElementsOfTheString(); 
                string str = mystring.FindingEvenElemenstInString();  //We assign the even values ​​of the string to the variable
            Console.WriteLine(str);
        }
    }
}

