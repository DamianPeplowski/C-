using System;

namespace pierwszeliczby
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            int[] array = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 1000);
            }

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < array[i]; j++)
                {
                    if (array[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    count++;
                }
            }

            Console.WriteLine("liczb pierwszych w tej tablicy jest: " + count);
        }
    }
}
