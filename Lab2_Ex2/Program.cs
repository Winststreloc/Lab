using System;

namespace Lab2_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (b == c)
            {
                Console.WriteLine("B = C");
                Console.WriteLine($"Расстояние = {Math.Abs(a - b)}");
            }
            if (Math.Abs(a - c) > Math.Abs(a - b))
            {
                Console.WriteLine("Точка B");
                Console.WriteLine($"Расстояние = {Math.Abs(a - b)}");
            }
            if (Math.Abs(a - b) > Math.Abs(a - c))
            {
                Console.WriteLine("Точка C");
                Console.WriteLine($"Расстояние = {Math.Abs(a - c)}");
            }
            Console.ReadKey();
        }
    }
}
