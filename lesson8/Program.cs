using System;

namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];
            numbers[0] = 55;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers.Length);
            int[] numbers2 = { 5, 7, 8 };
            Console.WriteLine(numbers2[2]);
            Console.WriteLine(numbers2.Length);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
