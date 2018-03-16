using System;
using System.Text;

namespace task_DEV_2
{
    /// <summary>
    /// This class finds the sequence of even indices.
    /// </summary>
    public class EvenElementsOfTheString
    {
        private string enteredstring;

        public EvenElementsOfTheString(string NewString) //constructor
        {
           this.enteredstring = NewString;
        }

        public string FindingEvenElemenstInString() //this function returns string with even elements
        {
            try
            {
                StringBuilder newstr = new StringBuilder("");
                for (int i = 0; i < enteredstring.Length; i += 2)
                {
                    newstr.Append(enteredstring[i]);
                }
                return newstr.ToString();
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("the string does not contain any characters");
                return string.Empty;
            }
        }
    }

}

