using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_DEV_8
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            string temp;
            do
            {
                Console.WriteLine("press 1 to add users");
                Console.WriteLine("press 2 to enter comand");
                Console.WriteLine("press 3 to exit");
                temp = Console.ReadLine();
                switch (temp)
                {
                    case "1":
                        menu.ADD();
                        break;
                    case "2":
                        menu.GetComand();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("the entered parameters are incorrect");
                        break;
                }
            } while (temp != "3");
        }
    }
}
