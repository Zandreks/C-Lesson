using System;

namespace lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            int count, readNumber;
            int[] arrNumbers;
            Console.WriteLine("enter count arr");
            try
            {
                count = Convert.ToInt32(Console.ReadLine());
                arrNumbers = new int[count];
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("enter num");
                    readNumber = Convert.ToInt32(Console.ReadLine());
                    arrNumbers[i] = readNumber;
                }
                Console.WriteLine("liast arr ");
                int suma =0;
                int maxNum = 0;
                for (int i = arrNumbers.Length -1; i >=0 ; i--)
                {
                    if (arrNumbers[i] % 2 == 0)
                    {
                        suma += arrNumbers[i];
                    }
                    if (arrNumbers[i] > maxNum)
                    {
                        maxNum = arrNumbers[i];
                    }
                    Console.WriteLine(arrNumbers[i]);
                }
                Console.WriteLine("suma all "+ suma);
                Console.WriteLine("Max numbers " + maxNum);
            }
            catch (Exception ex)
            {
                Console.WriteLine("not number");
            }
        }
    }
}
