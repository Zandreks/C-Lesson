using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0, count = 0;
            try
            {
                Console.WriteLine("enter dapozon number");
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("not number");
            }
            while (count < num)
            {
                count++;
                if(count %2 == 0)
                {
                    Console.WriteLine(count + " = четное");
                }
                else
                {
                    Console.WriteLine(count + " = не четное");

                }
            }
        }
    }
}
