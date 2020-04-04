using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                double a, b;
                string key;
                try
                {
                    Console.WriteLine("enter one nomber");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter two nomber");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter +-/*");
                    key = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("not number");
                    Console.ReadLine();
                    continue;
                }

                switch (key)
                {
                    case "+":
                        Console.WriteLine("rezult = " + (a + b));
                        break;
                    case "-":
                        Console.WriteLine("rezult = " + (a - b));
                        break;
                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine("rezult = " + 0);
                        }
                        else
                        {
                            Console.WriteLine("rezult = " + (a / b));

                        }
                        break;
                    case "*":
                        Console.WriteLine("rezult = " + (a * b));
                        break;
                    default:
                        Console.WriteLine("Not rezult");
                        break;
                }
                Console.ReadLine();


            }
        }
    }
}
