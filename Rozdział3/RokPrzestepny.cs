using System;

namespace RokPrzestepny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok:");
            int rok = int.Parse(Console.ReadLine());
            bool rokPrzestepny = false;
            if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
            {
                rokPrzestepny = true;
            }

            if (rokPrzestepny)
            {
                Console.WriteLine(rok + "jest to rok przestepny");
            }
            else
            {
                Console.WriteLine(rok + "nie jest to rok przestepny");
            }
        }
    }
}