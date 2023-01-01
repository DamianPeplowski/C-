using System;

namespace WyrazyLicz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz ciag wyrazów:");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            Console.WriteLine("Liczba wyrazów: " + words.Length);
        }
    }
}