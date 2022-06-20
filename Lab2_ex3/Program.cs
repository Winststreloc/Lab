using System;

namespace Lab2_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a,b,n");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            double h, x, y, s;

            x = a;
            h = (b - a) / 10;
            while (x <= b)
            {
                s = 1;
                y = ((Math.Pow((Math.E), x) - Math.Pow((Math.E), -x)) / 2);
                for (int i = 1; i <= n; i++)
                {

                    s += (Math.Pow(x, 2) / ((2 * Math.Pow(i, 2) + 1) * Math.Pow(x, 2 * i)));
                    Console.Write($"{x}    ");
                    Console.Write($"{y}    ");
                    Console.Write($"{s}    ");
                    Console.WriteLine();
                    x += h;
                }
            }
            Console.ReadKey();
        }
    }
}
