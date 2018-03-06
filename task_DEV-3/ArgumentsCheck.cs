using System;

namespace task_DEV_3
{
    class ArgumentsCheck
    {
        private int thebasisofanewnumbersystem;
        private int decimalnumber;
        public ArgumentsCheck(int x,int y)
        {
            this.decimalnumber = x;
            this.thebasisofanewnumbersystem = y;

        }
        /// <summary> 
        /// We check the arguments for the correctness of the input
        /// </summary>
        /// <returns>Is it allowed to continue the program</returns>
        public Boolean validationcheck()
        {
            if ((0 == decimalnumber) || (0 == thebasisofanewnumbersystem))
            {
                Console.WriteLine("no transfer parameters");
                return false;
            }
            if ((thebasisofanewnumbersystem < 1) || (thebasisofanewnumbersystem > 20))
            {
                Console.WriteLine("you have entered the wrong basis of the new system");
                return false;
            }
            return true;
        }
    }
}
