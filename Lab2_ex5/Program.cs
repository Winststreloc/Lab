using System;

namespace Lab2_ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number:");
            int N = Convert.ToInt32(Console.ReadLine());
            int k = 0;

            while (Math.Pow(3, k) < N)
            {
                k++;
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
