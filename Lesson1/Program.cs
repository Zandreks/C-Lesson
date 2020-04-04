using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //// vareble type
            //int num = 55;
            //float numF = 55.6f;
            //bool boolean = true;
            //string str = "tesr";
            //Console.WriteLine(num);
            //Console.WriteLine(numF);
            //Console.WriteLine(boolean);
            //Console.WriteLine(str);
            //Console.WriteLine(num);
            Console.WriteLine("enter one number");
            string str, str2;
            int a, b;
            str = Console.ReadLine();
            Console.WriteLine("enter two number");
            str2 = Console.ReadLine();
            try
            {
                a = Convert.ToInt32(str);
                b = Convert.ToInt32(str2);
                int result = a + b;
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("convert error");
            }

        }
    }
}
