using System;

namespace SumaCiagu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj Liczbe:");

            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                int s = (i % 2 == 0) ? -1 : 1;
                sum += s * i;
            }

            Console.WriteLine("Suma ciagu to: " + sum);
        }
    }
}