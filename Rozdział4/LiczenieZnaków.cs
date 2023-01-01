using System;
using System.Linq;

namespace LiczenieZnakow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz ciąg znaków:");
            string input = Console.ReadLine();

            var w= input.GroupBy(c => c)
                                   .ToDictionary(g => g.Key, g => g.Count());

            Console.WriteLine("Występowanie znaków: ");
            foreach (var kvp in w)
            {
                Console.WriteLine("{0} - {1}", kvp.Key, kvp.Value);
            }
        }
    }
}