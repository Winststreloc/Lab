using System;

namespace Lab2_ex1
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.Write("Введите x,y");
            double x = Convert.ToDouble(Console.Read());
            double y = Convert.ToDouble(Console.Read());
            double g;
            //int k = Convert.ToInt32(Console.Read());

            //алгоритм

            double a = Math.Abs(x * y);
            if (a > 10 || a < 0.5)
            {
                Console.WriteLine("Not result");
                return 1;
            }
            if (a < 0.5 || a > 0.1)
            {
                g = Math.Pow(1 + y, 1 / 3);
            }
            else
            {
                g = 2 * x;
            }

            Console.WriteLine($"Result: {g}");
            return 0;
        }
    }
}
