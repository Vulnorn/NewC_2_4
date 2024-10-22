using System;

namespace NewC_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int maxNumber = 101;
            int number = random.Next(maxNumber);
            int firstMultiple = 3;
            int secondMultiple = 5;
            int sumNumbers = 0;

            Console.WriteLine($"Заданное число {number} Последовательность всех чисел кратных {firstMultiple} и {secondMultiple}, которые меньше заданного числа");

            for (int i = 1; i <= number; i++) 
            { 
                if (i % firstMultiple == 0 && i % secondMultiple == 0)
                {
                    Console.Write($"{i} ");
                    sumNumbers = sumNumbers + i;
                }
            }
             
            Console.WriteLine($"Их сумма - {sumNumbers}");
            Console.ReadKey();            
        }
    }
}