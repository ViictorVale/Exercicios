using System;
using System.Globalization;
namespace Exercicio_12_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] alturas = new double[n];
            char[] sexo = new char[n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(s[1]);
            }

            //Mostrar a menor altura
            double menor = alturas[0];
            for (int i = 0; i < n; i++)
            {
                if (alturas[i] < menor)
                {
                    menor = alturas[i];
                }
            }
            Console.WriteLine("Menor altura = " + menor.ToString("F2", CultureInfo.InvariantCulture));

            //Mostrar a maior altura
            double maior = alturas[0];
            for (int i = 0; i < n; i++)
            {
                if (alturas[i] > maior)
                {
                    maior = alturas[i];
                }
            }
            Console.WriteLine("Maior altura = " + maior.ToString("F2", CultureInfo.InvariantCulture));

            //Mostrar a media das alturas das mulheres
            double somaDasAlturasDasMulheres = 0.0;
            int qdmulheres = 0;
            for (int i = 0; i < n; i++)
            {
                if (sexo[i] == 'F')
                {
                    somaDasAlturasDasMulheres = somaDasAlturasDasMulheres + alturas[i];
                    qdmulheres++;
                }
            }

            if (qdmulheres == 0)
            {
                Console.WriteLine("Nao ha nenhuma mulher dentre as pessoas");
            }
            else
            {
                double media = somaDasAlturasDasMulheres / qdmulheres;
                Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            }
            //Mostrar quantidade de homens
            int qdhomens = 0;
            for (int i = 0; i < n; i++)
            {
                if (sexo[i] == 'M')
                {
                    qdhomens++;
                }
            }
            Console.WriteLine("Numero de homens = " + qdhomens);
        }
    }
}
