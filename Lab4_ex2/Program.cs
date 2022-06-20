using System;

namespace Lab4_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] st = new char[100];
            char st2;
            int i, j;
            Console.WriteLine("Введите строку");
            for (int k = 0; k < 100; k++)
            {
                st[k] = Convert.ToChar(Console.ReadLine());
            }
            
            int n = st.Length;
            for (i = 0; i < n; i++)
            {

                if (st[i] == '+' || st[i] == '-')
                {
                    st2 = st[i];
                    for (j = i + 1; j < n; j++) ;
                    {
                        if (st[j] < '0' || st[j] > '9') break;
                        st2 += st[j];
                    }

                }

            }
        }
    }
}
