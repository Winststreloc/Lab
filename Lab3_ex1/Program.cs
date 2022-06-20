using System;
using System.Text;

namespace Lab3_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k;
            int n;

            Console.WriteLine("Введите k эл-ов массива: ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите n сдвигов массива: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[k];

            Random rand = new();

            Console.WriteLine("Вывод массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(arr.Length);
                Console.Write(arr[i]);
                Console.Write(" ");
            }

            Console.WriteLine("\nВывод  сдвинутого массива: ");

            for (int i = 0; i < arr.Length - n; i++)
            {
                if (i == arr.Length - n)
                {
                    Console.Write(^(arr.Length - n));
                }

            }

            Console.WriteLine("\nНеповторяющиеся элементы массива: ");
            for (int i = 0; i < arr.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < arr.Length; ++j)
                    if (i != j && arr[i] == arr[j])
                    {
                        flag = false;
                        break;
                    }

                if (flag)
                {
                    Console.Write(arr[i]);
                    Console.Write(" ");
                }
            }
        }

        private static string GetRLEstring(string str)
        {
            int length = str != null ? str.Length : 0;
            int compressStrLength = GetRLEstringLength(str);
            if (length == 1 || compressStrLength >= str.Length)
            {
                return str;
            }

            char symbol = str[0]; int tempCount = 0;
            StringBuilder compressStr = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (symbol == str[i])
                {
                    tempCount++;
                }

                // если предыдущий символ не равен текущему ИЛИ 
                // итерация является последней то обнуляем счетчик
                if (symbol != str[i] || i == str.Length - 1)
                {
                    compressStr.Append(symbol.ToString() + tempCount);
                    tempCount = 1;
                    symbol = str[i];
                }
            }
            return compressStr.ToString();
        }

        private static int GetRLEstringLength(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int length = 0, tempCount = 0;
            char symbol = str[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (symbol == str[i])
                {
                    tempCount++;
                }

                // если предыдущий символ не равен текущему ИЛИ 
                // итерация является последней, то обнуляем счетчик
                if (symbol != str[i] || i == str.Length - 1)
                {
                    length += tempCount.ToString().Length + 1;
                    symbol = str[i];
                    tempCount = 0;
                }
            }
            return length;
        }
    }
}
