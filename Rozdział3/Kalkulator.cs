using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbe:");

            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbe:");

            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj znak jaką operacje chcesz wykonac (+ , - , * , /):");

            char op = char.Parse(Console.ReadLine());

            double result = 0.0;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Nieodpowiedni znak.");
                    break;
            }

            Console.WriteLine("Wynik to: " + result);
        }
    }
}