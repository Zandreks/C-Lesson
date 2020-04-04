using System;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "qwerty";
            bool answer = false;
            Console.WriteLine("enter password");

            string newpassword = Console.ReadLine();
            answer = password == newpassword ? true : false;
            Console.WriteLine(answer);
        }
    }
}
