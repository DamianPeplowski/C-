using System;

namespace BMIKalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wage w kg:");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w metrach:");
            double height = double.Parse(console.ReadLine());
            double bmi = weight / (height * height);
            Console.WriteLine("Twoje BMI to: " + bmi);
        }
    }
}