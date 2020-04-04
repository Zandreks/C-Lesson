using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Условие
            double oneNumber, twoNumber;
            Console.WriteLine("enter one number");
            oneNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter two number");
            twoNumber = Convert.ToDouble(Console.ReadLine());
            if(oneNumber >= twoNumber)
            {
                Console.WriteLine(oneNumber + " >= " + twoNumber);
            }
            else
            {
                Console.WriteLine(oneNumber + " < !== " + twoNumber);

            }
            if(oneNumber%2 == 0)
            {
                Console.WriteLine(oneNumber +" Четное");
            }
            else
            {
                Console.WriteLine(oneNumber + " не четное");
            }
            if (twoNumber % 2 == 0)
            {
                Console.WriteLine(twoNumber + " Четное");
            }
            else
            {
                Console.WriteLine(twoNumber + " не четное");
            }
        }
    }
}
