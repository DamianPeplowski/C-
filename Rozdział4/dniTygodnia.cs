using System;

namespace dniTygodnia
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] dniTygodnia = new string[7, 3];

            dniTygodnia[0, 0] = "Poniedziałek";
            dniTygodnia[1, 0] = "Wtorek";
            dniTygodnia[2, 0] = "Środa";
            dniTygodnia[3, 0] = "Czwartek";
            dniTygodnia[4, 0] = "Piątek";
            dniTygodnia[5, 0] = "Sobota";
            dniTygodnia[6, 0] = "Niedziela";
            dniTygodnia[0, 1] = "Monday";
            dniTygodnia[1, 1] = "Tuesday";
            dniTygodnia[2, 1] = "Wednesday";
            dniTygodnia[3, 1] = "Thursday";
            dniTygodnia[4, 1] = "Friday";
            dniTygodnia[5, 1] = "Saturday";
            dniTygodnia[6, 1] = "Sunday";
            dniTygodnia[0, 2] = "Montag";
            dniTygodnia[1, 2] = "Dienstag";
            dniTygodnia[2, 2] = "Mittwoch";
            dniTygodnia[3, 2] = "Donnerstag";
            dniTygodnia[4, 2] = "Freitag";
            dniTygodnia[5, 2] = "Samstag";
            dniTygodnia[6, 2] = "Sonntag";


            Console.WriteLine("Dni tygodnia w trzech językach Polskim,Angielskim,Niemieckim");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(dniTygodnia[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}



