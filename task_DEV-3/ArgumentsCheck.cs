using System;
namespace task_DEV_3
{  /// <summary> 
   /// ArgumentsCheck
   /// verifies the correctness of entering arguments
   /// </summary>
    class ArgumentsCheck
    {
        private string thebasisofanewnumbersystem;
        private string decimalnumber;
        public ArgumentsCheck(string[]args)
        {
            this.decimalnumber = args[0];
            this.thebasisofanewnumbersystem = args[1];
        }
        /// <summary> 
        /// We check the arguments for the correctness of the input
        /// </summary>
        /// <returns>Is it allowed to continue the program</returns>
        public Boolean validate()
        {
            if ((decimalnumber == string.Empty) || (string.Empty == thebasisofanewnumbersystem))
            {
                Console.WriteLine("string empty");
                return false;
            }

            try
            {
                int FirstArgyment = Int32.Parse(decimalnumber);
                int SecondArgyment = Int32.Parse(thebasisofanewnumbersystem);
            }
            catch (FormatException)
            {
                Console.WriteLine("Can not convert arguments to an integer type");
                return false;
            }    
            
                if ((Convert.ToInt32(thebasisofanewnumbersystem) < 1) || (Convert.ToInt32(thebasisofanewnumbersystem) > 20))
            {
                Console.WriteLine("you have entered the wrong basis of the new system");
                return false;
            }

            return true;
        }
    }
}
