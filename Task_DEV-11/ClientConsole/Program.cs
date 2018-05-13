using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task_DEV_11;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int day,months,year;
            do
            {
                day = Convert.ToInt32(Console.ReadLine());
            }
            while (day < 0 || day > 31);
            do
            {
                months = Convert.ToInt32(Console.ReadLine());
            }
            while (months < 0 || months > 12);
            do
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            while (year < 0);
            Server server = new Server();
            int days=server.PrintDaysFromChristsBirthday(year, months, day);
            Console.WriteLine("amount of days="+days);
        }
    }
}
