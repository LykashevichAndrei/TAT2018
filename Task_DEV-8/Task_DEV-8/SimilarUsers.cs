using System;
using System.IO;

namespace Task_DEV_8
{
    class SimilarUsers
    {
        public void Write(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName);
            string way = @"C:\\Users\\mnepo\\source\\TAT2018\\Task_DEV-8\\Task_DEV-8\\SimilarUsers.txt";
            using (StreamWriter sw = new StreamWriter(way, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(user.FirstName + " " + user.LastName);
                sw.WriteLine();
            }
        }
    }
}
