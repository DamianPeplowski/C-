using System;

namespace SumaPrzekatnej
{
    class Program
    {
        static void Main(string[] args)
        {

            double[,] a = { { 1.2, 2.2, 3.3, 4.4, 5.5 }, 
                               { 6.6, 7.7, 8.8, 9.9, 10.1 }, 
                               { 11.1, 12.2, 13.3, 14.4, 15.5 }, 
                               { 16.6, 17.7, 18.8, 19.9, 20.1 }, 
                               { 21.1, 22.2, 23.3, 24.4, 25.5 } };

            Console.WriteLine("Tablica");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += a[i, i];
            }
            Console.WriteLine("suma elementów znajdujących się na głównej przekątnej tablicy: " + sum);
        }
    }
}
