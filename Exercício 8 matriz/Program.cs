using System;

namespace Exercício_8_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = Console.ReadLine().Split(' ');
            int m = int.Parse(s1[0]);
            int n = int.Parse(s1[1]);
            int[,] mat1 = new int[m, n];
            int[,] mat2 = new int[m, n];
            int[,] mat3 = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat1[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < m; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat2[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat3[i, j] = mat1[i, j] + mat2[i, j];
                }
              
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat3[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
