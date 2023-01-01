using System;

namespace kopiowanieTablicy
{
    class Program
    {
        static void Main(string[] args)
        {
 
            int[] tab1 = { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10 };

            int[] tab2 = new int[tab1.Length];

            int count = 0;
            for (int i = 0; i < tab1.Length; i++)
            {
                if (tab1[i] > 0)
                {
                    tab2[count] = tab1[i];
                    count++;
                }
            }

            Console.WriteLine("tab2 to");
            for (int i = 0; i < count; i++)
            {
                Console.Write(tab2[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
