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

            if (delta > 0)
            {
                Console.WriteLine("Rownanie kwadratowe ma dwa miejsca zerowe.");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Rownanie kwadratowe ma jedno miejsce zerowe");
            }
            else
            {
                Console.WriteLine("Rownanie kwadratowe niema rozwiazania");
            }
        }
    }
}
