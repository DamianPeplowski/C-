using System;

namespace tablica
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj licze elementow tablicy:");

            int num = int.Parse(Console.ReadLine());

            int[] tablica = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Elementy tablicy"+ (i + 1) + ":");
                tablica[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Tablica:");
            for (int i = 0; i < num; i++)
            {
                Console.Write(tablica[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
