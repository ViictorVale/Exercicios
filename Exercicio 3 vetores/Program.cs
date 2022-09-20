using System;
using System.Globalization;
namespace Exercicio_3_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a;
            int n = int.Parse(Console.ReadLine());
            a = new double [n];

            string[] linha = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                a[i] = double.Parse(linha[i], CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();
            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma = soma + a[i];
            }
            double media = soma / n;
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
