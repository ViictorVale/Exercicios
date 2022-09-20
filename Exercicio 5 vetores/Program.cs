using System;
using System.Globalization;
namespace Exercicio_5_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] num = new double[n];
            string[] linha = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                num[i] = double.Parse(linha[i], CultureInfo.InvariantCulture);
            }

            // Mostrar o maior número e a posiçao dele
            double maior = num[0];
            int posicao = 0;
            for(int i = 0; i < n; i++)
            {
              if (num[i] > maior)
                {
                    maior = num[i];
                    posicao = i;
                }
            }
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
        }
    }
}
