using System;

namespace SumaLiczb
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;

            Console.WriteLine("Podaj liczbe(wprowadz 0 by zatrzymac program):");

            int num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                sum += num;

                Console.WriteLine("Podaj liczbe(wprowadz 0 by zatrzymac program):");

                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Suma liczb to: " + sum);
        }
    }
}