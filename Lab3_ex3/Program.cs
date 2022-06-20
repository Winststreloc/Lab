using System;

namespace Lab3_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Enter M: ");
            int m;
            m = Console.Read();

            Console.WriteLine("Enter N: ");
            int n;
            n =  Console.Read();

            int[,] p = new int[m, n];

            for (int i = 0; i < m; i++) 
            { 
                p[i, 0] = n; 
            }

            int temp = 1;
            for (int i = 0; i < m; i++)                 //Устанавлисваем значения в массив
                for (int j = 0; j < n; j++, temp++)
                {
                    if (temp == 10)
                        temp = 1;
                    p[i, j] = temp;
                }

            for (int i = 0; i < m; i++)
            {                //Вывод массива на экран
                for (int j = 0; j < n; j++) 
                {
                    Console.WriteLine(p[i, j]); 
                }

                Console.WriteLine(" ");
            }

            temp = 99999999;
            for (int i = 0; i < m; i++)
            {                 //Ищем наименьшее значение
                for (int j = 0; j < n; j++)
                    if (temp > p[i, j])
                        temp = p[i, j];
            }

            for (int i = 0; i < m; i++)
            {                 //Устанавлисваем 0 место минимума
                for (int j = 0; j < n; j++)
                    if (p[i, j] == temp)
                        p[i, j] = 0;
            }

            Console.WriteLine(" ");

            for (int i = 0; i < m; i++)
            {                //Вывод массива на экран
                for (int j = 0; j < n; j++)
                    Console.WriteLine(p[i, j]);
                Console.WriteLine(" ");
            }


            Console.ReadKey();
        }
    }
}
