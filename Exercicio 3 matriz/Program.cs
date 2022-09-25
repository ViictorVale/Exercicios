using System;

namespace Exercicio_3_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] s1 = Console.ReadLine().Split(' ');
            int m = int.Parse(s1[0]);
            int n = int.Parse(s1[1]);
            int[,] matriz = new int[m, n];
            int[] vet = new int[m];

            for (int i = 0; i < m; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                   matriz[i, j] = int.Parse(s[j]);
                }
            }
            
            for (int i = 0; i < m; i++)
            {
                int soma = 0;
                for (int j = 0; j < n; j++)
                {
                    soma = soma + matriz[i, j];
                }
                vet[i] = soma;
                Console.WriteLine(vet[i]);
            }
           
        }
    }
}
