using System;

namespace task_DEV_3
{
    /// <summary> 
    /// EntryPoint
    /// enter two arguments: 
    /// 1) the number that we must translate into another system
    /// 2) the foundation of a new system 
    /// </summary>
    class task_DEV3
    {
        static void Main(string[] args)
        {
            Boolean check = validationcheck(args);
            if (true == check)
            {
                int decimalnumber = Convert.ToInt32(args[0]);
                int system = Convert.ToInt32(args[1]);
                NewNumberSystem number = new NewNumberSystem(decimalnumber, system);
                string answer = number.calculatenewsystem();
                answer = number.ReverseAnswer(answer);
                Console.WriteLine(answer);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("check the correctness of the input");
                Console.ReadLine();
            }
        }
        /// <summary> 
        /// We check the arguments for the correctness of the input
        /// </summary>
        /// <returns>Is it allowed to continue the program</returns>
        public static Boolean validationcheck(string[] args)
        {
            if ((null == args[0]) || (null == args[1]))
            {
                Console.WriteLine("no transfer parameters");
                return false;
            }
            if ((Convert.ToInt32(args[1]) < 1) || (Convert.ToInt32(args[1]) > 20))
            {
                Console.WriteLine("you have entered the wrong basis of the new system");
                return false;
            }
            int numberForCheck;
            if (!Int32.TryParse(args[0], out numberForCheck) || !Int32.TryParse(args[1], out numberForCheck))
            {
                Console.WriteLine("Not only numbers are introduced");
                return false;
            }
            return true;
        }
    }
}
