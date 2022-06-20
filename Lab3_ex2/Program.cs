using System;

namespace Lab3_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("Enter m: ");
            m = Console.Read();
            Console.WriteLine("Enter n: ");
            n = Console.Read();
            char[,] mas = new char[n, m];
           
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Enter {i},{j}");
                    mas[i, j] = (char)n;
                }
            }
        }
    }
}
