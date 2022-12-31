using System;

namespace liczba100
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int counter = 1;

            while (sum <= 100)
            {
                sum += counter;
                counter++;
            }

            Console.WriteLine("Liczba potrzebna aby wynik przekroczył 100: " + (counter - 1));
        }
    }
}