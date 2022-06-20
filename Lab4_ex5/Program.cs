using System;
using System.Linq;

namespace Lab3_ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int n = Console.Read();
            int[] Arr = new int[n];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"A = {i + 1}");
                Arr[i] = Console.Read();
            }
            
            Console.WriteLine(Arr.Distinct().Count());

        }
    }
}
