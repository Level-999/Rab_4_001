using System;

namespace ConsoleApp3
{
    internal class Program
    {
        
         static void Main(string[] args)
        {
            Console.WriteLine("Y:");
            int y = int.Parse(Console.ReadLine());

            for (int i = 1; i <= y; i+=2)
                
                    Console.Write("{0} ", i);
        }
    }
}
