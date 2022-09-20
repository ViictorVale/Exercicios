using System;
using System.Globalization;
namespace Exercicio_4_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            string[] nomes = new string[n];
            int[] idades = new int[n];
            double[] alturas = new double[n];
           
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = (s[0]);
                idades[i] = int.Parse(s[1]);
                alturas[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            // Calculo da altura média
            for(int i = 0; i < n; i++)
            {
                soma = soma + alturas[i];
               
            }
            double media = (double)soma / n;
            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            // Calculo da porcentagem
            int cont = 0;
            for(int i = 0; i< n; i++)
            {
                if (idades[i] < 16)
                {
                    cont++;
                }
            }
            double porcentagem = (double)cont * n / 100;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");
        }
    }
}
