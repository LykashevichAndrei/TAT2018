using System;
using System.IO;


namespace _3task
{
    class Program
    {
        static void Main(string[] args)
        {
            string expansion = args[0];
            string way = Console.ReadLine();
            string[] result;
            result=Directory.GetFiles(way, expansion, SearchOption.AllDirectories);
            foreach (string element in result)
            Console.WriteLine(element);
        }
    }
}
