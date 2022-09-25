using System;

namespace Exercicio_4_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = Console.ReadLine().Split(' ');
            int m = int.Parse(s1[0]);
            int n = int.Parse(s1[1]);
            int[,] mat = new int[m, n];

            for(int i = 0; i < m; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS: ");
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(mat[i,j] < 0)
                    {
                        Console.WriteLine(mat[i, j]);
                    }
                }
            }
        }
    }
}
