using System;
namespace Exercicio_6_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            string[] linha = Console.ReadLine().Split(' ');

            for(int i = 0; i < n; i++)
            {
                num[i] = int.Parse(linha[i]);
            }

            // Mostrar todos os números pares
            int numpares = 0;
            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                if (num[i] % 2 == 0)
                {
                    numpares = num[i];
                    cont++;
                    Console.Write(numpares + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine(cont);
        }
    }
}
