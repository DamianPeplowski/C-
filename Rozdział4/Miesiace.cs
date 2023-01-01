using System;

namespace Miesiące
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz date w formacie DD-MM-RRRR:");
            string input = Console.ReadLine();

            string data= input.Substring(3, 2);
            int m = int.Parse(data);

            switch (m)
            {
                case 1:
                    Console.WriteLine("Styczen");
                    break;
                case 2:
                    Console.WriteLine("Luty");
                    break;
                case 3:
                    Console.WriteLine("Marzec");
                    break;
                case 4:
                    Console.WriteLine("Kwiecień");
                    break;
                case 5:
                    Console.WriteLine("Maj");
                    break;
                case 6:
                    Console.WriteLine("Czerwiec ");
                    break;
                case 7:
                    Console.WriteLine("Lipiec ");
                    break;
                case 8:
                    Console.WriteLine("Sierpień");
                    break;
                case 9:
                    Console.WriteLine("Wrzesień");
                    break;
                case 10:
                    Console.WriteLine("Pażdziernik");
                    break;
                case 11:
                    Console.WriteLine("Listopad");
                    break;
                case 12:
                    Console.WriteLine("Grudzień");
                    break;
                default:
                    Console.WriteLine("nieznana data");
                    break;
            }
        }
    }
}