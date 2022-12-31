using System;

namespace RownanieKwadratowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c:");
            double c = double.Parse(Console.ReadLine());
            double delta = b * b - 4.0 * a * c;
            Console.WriteLine("Delta jest rowna: " + delta);
        }
    }
}