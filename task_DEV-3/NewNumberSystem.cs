using System.Text;
namespace task_DEV_3
{    /// <summary> 
     /// NewNumberSystem
     /// creates a string that is a translation of a number into another number system
     /// </summary>
    class NewNumberSysteminterpreter
    {
        private int number;
        private int numbersystem;

        public NewNumberSysteminterpreter(int decimalnumber,int system)
        {
            this.number = decimalnumber;
            this.numbersystem =system;
        }
        /// <summary> 
        /// Method calculatenewsystem
        /// translate to another system of notations
        /// </summary> 
        /// <returns>number in the new number system</returns>
        public string calculatenewsystem()
        {
            string elements = "0123456789ABCDEFGHIJK";
            int remainderofthedivision = 0;
            StringBuilder answer = new StringBuilder();
            do
            {
                remainderofthedivision = number % numbersystem;
                number /= numbersystem;
                answer.Append(elements[remainderofthedivision]);
            }
            while (number > 0);

            return answer.ToString();
        }
        /// <summary> 
        /// the method inverts the string
        /// </summary> 
        /// <returns>inverted number in the new number system</returns>
        public string ReverseAnswer(string str)
        {
            StringBuilder strReverse = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                strReverse.Append(str[i]);
            }
            return strReverse.ToString();
        }
    }
}
