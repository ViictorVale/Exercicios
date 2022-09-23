using System;

namespace Exercicio_1_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int m = int.Parse(s[0]);
            int n = int.Parse(s[1]);
            int[,] a = new int[m, n];
            
            for(int i = 0; i < m; i++)
            {
                string[] s1 = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(s1[j]);
                }
            }

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
           
        }
    }
}
