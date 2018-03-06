using System;
namespace MaxNumberOfCharacters
{
    class FindMaxSequnceInString //finds the maximum subseqence of characters in the string
    {
        private int FindMaxSequnce(char[] str)
        {
            int max_length = 0;
            int counter = 1;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    counter++;//increase the values of the counter ,if the symbols match
                }
                else
                {
                    counter = 1;//equate to zero if the symbols don't match
                }
                if (max_length < counter)
                {
                    max_length = counter;
                }
            }
            return (max_length);
        }
        private void Result(int length) //output result's
        {
            if (length == 1)
            {
                Console.WriteLine("duplicate character not found");
            }
            else
            {
                Console.WriteLine(length);
            }
        }
    }
}
