using System;

namespace lab2exer2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Ex 2: Scrieti un program care va afisa factorialul unui numar n, n fiind citit
           de la tastatura.*/

            Console.WriteLine("Introduceti un numar:");

            int n = int.Parse(Console.ReadLine());
            int f = 1;

            while (n > 0)
            {
                f = f * n;
                n = n - 1;
            }
            




           Console.WriteLine("Numarul este: " + f);
        }
    }
}