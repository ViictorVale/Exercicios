using System;

namespace Exercio_2_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet;
            int n = int.Parse(Console.ReadLine());
            vet = new int[n];

            string[] linha = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(linha[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if(vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}
