using System;

namespace BMIKalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wage w kg:");

            double waga = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wzrost w metrach:");

            double wzrost = double.Parse(Console.ReadLine());

            double bmi = waga / (wzrost * wzrost);

            if (bmi < 18.5)
            {
                Console.WriteLine("Niedowaga");
            }
            else if (bmi >= 18.5 && bmi <= 24.99)
            {
                Console.WriteLine("Norma.");
            }
            else
            {
                Console.WriteLine("Masz nadwage.");
            }
        }
    }
}