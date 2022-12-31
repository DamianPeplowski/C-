using System;

namespace Silnia
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj liczbę:");

            int num = int.Parse(Console.ReadLine());

            long silnia = 1;
            for (int i = 1; i <= num; i++)
            {
                silnia *= i;
            }

            Console.WriteLine("Silnia " + num + " to " + silnia + ".");
        }
    }
}