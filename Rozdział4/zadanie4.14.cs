using System;

namespace zadanie414
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "KOMG-2002", "BH-2014", "XYZ-2018", "ABC-2009", "DEF-2015" };

            int b = DateTime.Now.Year;

            Console.WriteLine("Produkty: ");
            foreach (string asset in a)
            {

                string ra= asset.Substring(asset.Length - 4);
                int r = int.Parse(ra);

                int l = b - r;
                Console.WriteLine("{0}: {1} lat", asset, l);
            }
        }
    }
}
