
using System;

namespace MaxLiczba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwsza liczbę:");
            double num1 = double.Parse(console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            double num2 = double.Parse(console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę:");
            double num3 = double.Parse(console.ReadLine());
            double max = num1;
            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }

            Console.WriteLine("Najwyższa liczba: " + max);
        }
    }
}