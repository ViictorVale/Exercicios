using System;
using System.Globalization;
namespace Exercicio_9_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(s[i]);
            }

            //media dos números pares
            double soma = 0.0;
            int qdpares = 0;
            for(int i = 0; i < n; i++)
            {
                if(num[i] % 2 == 0)
                {
                    soma = soma + num[i];
                    qdpares++;
                }
            }
            double media = (double)soma / qdpares;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
