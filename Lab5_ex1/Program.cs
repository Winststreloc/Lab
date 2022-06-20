using System;
using System.Collections.Generic;

namespace Lab5_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var websites = new Stack<string>();
            var oldweb = new Stack<string>();
            websites.Push("http://www.asm.org");
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "back")
                {
                    if (websites.Count == 1)
                    {
                        Console.WriteLine("Ignored");
                    }
                    else
                    {
                        websites.Pop();
                        Console.WriteLine(websites.Peek());
                    }
                }
                else if (cmd == "forward")
                {
                    if (oldweb.Count == 0)
                    {
                        Console.WriteLine("Ignored");
                    }
                    else
                    {
                        websites.Push(oldweb.Pop());
                        Console.WriteLine(websites.Peek());
                    }
                }
                else if (cmd == "visit")
                {
                    string website = Console.ReadLine();
                    websites.Push(website);
                    oldweb.Push(website);
                    Console.WriteLine(website);
                }
                else if (cmd == "quit")
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
