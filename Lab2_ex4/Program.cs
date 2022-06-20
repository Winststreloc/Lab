using System;

namespace Lab2_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factorial = Convert.ToInt32(Console.ReadLine());
            int n = factorial;
            for (int i = 1; i < n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
            Console.ReadKey();
        }
    }
}
