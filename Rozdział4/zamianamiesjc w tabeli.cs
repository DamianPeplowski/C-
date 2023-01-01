using System;

namespace ZamianaMiejsc
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tab1 = { 1, 2, 3, 4, 5 };

            int[] tab2 = new int[tab1.Length];

            tab2[0] = tab1[tab1.Length - 1];
            for (int i = 1; i < tab1.Length; i++)
            {
                tab2[i] = tab1[i - 1];
            }

            Console.WriteLine("tab2 to");
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.Write(tab2[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
