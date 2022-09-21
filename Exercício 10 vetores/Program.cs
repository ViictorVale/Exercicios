using System;

namespace Exercício_10_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nomes = new string[n];
            int[] idades = new int[n];
            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = (s[0]);
                idades[i] = int.Parse(s[1]);
            }

            //mostrar a maior idade
            int maior = idades[0];
            string nomemaior = nomes[0];
            for(int i = 0; i < n; i++)
            {
                if(idades[i] > maior)
                {
                    nomemaior = nomes[i];
                    maior = idades[i];
                }
            }
            Console.WriteLine("Pssoa mais velha: " + nomemaior);
        }
    }
}
