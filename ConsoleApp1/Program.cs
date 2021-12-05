using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N = Convert.ToDouble(Console.ReadLine());
            double razmer = 2 * N - 1;
            double chislo = 2;
            double rezult = 0;
            for (int i = 0; i < razmer / 2; i++)
            {
                if (razmer >= chislo)
                {
                    rezult += razmer - chislo;
                    chislo += 2;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Квадрат числа N = " + Math.Sqrt(rezult));
            Console.ReadKey();
        }
    }
}
