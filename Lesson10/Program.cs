using System;
using System.Linq;

namespace Lesson10
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
                int suma = arrNumbers.Where(i=>i%2==0).Sum();
                int maxNum = arrNumbers.Max(); 
                int findNum = arrNumbers.Where(i => i == 66).FirstOrDefault();
                int[] findGroup = Array.FindAll(arrNumbers, i => i == 2);
                int[] newarr = arrNumbers.Reverse().ToArray();
                for (int i = 0; i < newarr.Length; i++)
                {
                    Console.WriteLine(newarr[i]);
                }
                Console.WriteLine("suma all " + suma);
                Console.WriteLine("Max numbers " + maxNum);
                Console.WriteLine("find arr num" +findNum);
                Console.WriteLine("find arr group" + findGroup[0]);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("not number", ex);
            }
        }
    }
}
