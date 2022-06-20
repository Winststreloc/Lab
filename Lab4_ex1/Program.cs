using System;

namespace Lab4_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
                Console.WriteLine("Введите строку: ");
                string a = Console.ReadLine();
                Console.WriteLine("Исходная строка: " + a);
                Console.WriteLine("Введите необходимую длину слова: ");
                int x = int.Parse(Console.ReadLine());
                foreach (string word in a.Split(new char[] { ' ', ',', '.', ';', ':' }, StringSplitOptions.RemoveEmptyEntries))
                    if (word.Length == x)
                        Console.WriteLine(word);
        
        }
    }
}
