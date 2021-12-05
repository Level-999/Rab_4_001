using System;

namespace Rab_4_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую формулу:
            //N2=1 + 3 + 5 + ... + (2*N – 1). После добавления к сумме каждого слагаемого выводить текущее значение
            //суммы (в результате будут выведены квадраты всех целых чисел от 1 до N).

            Console.Write("Введите целое число N>0: ");

            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Квадрат числа N2=" + Math.Pow(a, 2));
            
            double b = (2 * a - 1);
            Console.WriteLine();
            Console.WriteLine("Расчётная формула N2=1 + 3 + 5 + 7 + 9 ... + (2*N – 1) ");

            Console.WriteLine();
            for (int i = 1; i <= b-1; i += 2)
                            
            {
                Console.WriteLine("Квадрат всех нечётных чисел от 1 до N " + Math.Pow(i, 2));
            }
                   
           
            Console.Read();

        }
    }
}
