using System;
using System.Globalization;
namespace Exercício_11_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nomes = new string[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];

            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = (s[0]);
                nota1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Alunos aprovados:");
           
            for (int i = 0; i < n; i++)
            {
               double media = (nota1[i] + nota2[i]) / 2.0;
                if(media >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}
