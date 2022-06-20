using System;

namespace Лаболаторные
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус и высоты цилиндра");
            short rad = Convert.ToInt16(Console.ReadLine());
            short height = Convert.ToInt16(Console.ReadLine());
            double volume = Math.PI * rad * rad * height;
            Console.WriteLine($"Объём цилиндра равен:{volume}");
            Console.ReadKey();
        }
    }
}
