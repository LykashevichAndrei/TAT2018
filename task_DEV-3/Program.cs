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
            ArgumentsCheck test = new ArgumentsCheck(args);
            Boolean check = test.validationcheck();
            
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
    }
}
