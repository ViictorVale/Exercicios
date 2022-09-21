using System;
using System.Globalization;
namespace Exercício_8_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            string[] s = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++)
            {
                a[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            double soma = 0;
            // soma dos números
            for (int i = 0; i < n; i++)
            {
                soma = soma + a[i];
            }
            double media = soma / n;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            // mostrar todos os elementos que estejam a baixo da média
            for(int i = 0; i < n; i++)
            {
                if(a[i] < media)
                {
                    Console.WriteLine(a[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
