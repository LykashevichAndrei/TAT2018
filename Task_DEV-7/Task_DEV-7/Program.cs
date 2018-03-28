using System.IO;

namespace Task_DEV_7
{
    class Program
    {
        static void Main(string[] args)
        {
            menu m = new menu();
            m.mainmenu(args[0]);
        }
    }
}
