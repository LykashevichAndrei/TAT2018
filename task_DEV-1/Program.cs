using System;

namespace Task1
{   /// <summary>
    /// Class MaxNumberOfCharacters
    /// searches maximum number of same serial symbols in the string
    /// and searches some exceptions
    /// </summary>
    class MaxNumberOfCharacters
    {
        public static void Main(string[] arg)
        {
            try
            {
                FindMaxSequnceInString example = new FindMaxSequnceInString; //create instance of a class
                var str = arg[0].ToCharArray();
                int length = example.FindMaxSequnceInString(str); //find concurrences
                example.Result(length);
            }
            catch
            {
                Console.WriteLine("ERROR");
                Console.WriteLine("the function takes too many arguments");
            }
        }
    }
}