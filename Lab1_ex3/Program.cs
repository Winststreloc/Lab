using System;

namespace Lab1_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько кг конфет?");
            int x = Console.Read();
            Console.WriteLine("Сколько стоят?");
            int price = Console.Read();
            Console.WriteLine("Сколько кг конфет нужно?");
            int y = Console.Read();

            Console.WriteLine($"1 кг стоит: {price / x} \n {y} кг конфет будет стоить:");
        }
    }
}
