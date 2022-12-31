using System;

namespace monety
{
    class Program
    {
        static void Main(string[] args)
        {

            int c1 = 0;
            int c2 = 0;
            int c5 = 0;

            while (c1 <= 10)
            {
                while (c2 <= 5)
                {
                    while (c5 <= 2)
                    {
                        if (c1 + 2 * c2 + 5 * c5 == 10)
                        {
                            Console.WriteLine(c1 + " PLN 1 moneta, " + c2 + " PLN 2 moneta , " + c5 + " PLN 5 moneta");
                        }
                        c5++;
                    }
                    c5 = 0;
                    c2++;
                }
                c2 = 0;
                c1++;
            }
        }
    }
}





