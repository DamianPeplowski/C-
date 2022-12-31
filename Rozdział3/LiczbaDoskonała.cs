using System;

namespace LiczbaDoskonala
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj Liczbe:");

            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Liczba doskonała pomiedzy <1, " + num + "> to:");
            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }

                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}