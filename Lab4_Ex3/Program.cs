using System;

namespace Lab4_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string InputString = @"one   two     three";
            Console.WriteLine(string.Join(".", InputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)));
        }
    }
}
