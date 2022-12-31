using System;

namespace Podzielna
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj pierwsza liczbe:");

            int num1 = int.Parse(console.ReadLine());

            Console.WriteLine("Podaj druga liczbe:");

            int num2 = int.Parse(console.ReadLine());

            if (num1 % num2 == 0)
            {
                Console.WriteLine(num2 + " jest podzielna przez " + num1 + ".");
            }
            else
            {
                Console.WriteLine(num2 + " nie jest podzielna przez " + num1 + ".");
            }
        }
    }
}