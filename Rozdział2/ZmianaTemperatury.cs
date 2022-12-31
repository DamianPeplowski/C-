
using System;
namespace ZmianaTemperatury
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj temperature w celsjuszach:");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9.0 / 5.0) + 32.0;
            Console.WriteLine("Temperatura w stopniach Fahrenheit to: " + fahrenheit);
        }
    }
}

