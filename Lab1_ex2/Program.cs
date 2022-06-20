using System;

namespace Lab1_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //short number = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Последняя цифра:{0} \nВторая цифра: {1} ", number % 10, ((number % 100) - (number % 10)) / 10);
            //Console.ReadKey();



            int number = 456, i = 0;
            for (int k = 0; number > 10; i++)
            {
                k = number % 10;
                number /= 10;
                Console.WriteLine(k);
            }
        }
    }
}
