using System;
using System.Linq;

namespace LiczySłowa
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie odpowiedział Puchatek";

            string[] s = input.Split(' ');

            var wys= s.GroupBy(w => w)
                                   .ToDictionary(g => g.Key, g => g.Count());

            Console.WriteLine("Występowanie słów:");
            foreach (var kvp in wys)
            {
                if (kvp.Value > 1)
                {
                    Console.WriteLine("{0} - {1} razy", kvp.Key, kvp.Value);
                }
            }
        }
    }
}
