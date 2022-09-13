using System;
using System.Globalization;
namespace Exercicio_faca_enquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            string condicao;
            do
            {
                Console.Write("Digite a temperatura em Celsius: ");
                double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double F = 9 * C / 5 + 32;
                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja repetir (s/n)? ");
                condicao = (Console.ReadLine());
                while (condicao != "s" && condicao != "n")
                {
                    Console.WriteLine("Digite s ou n! ");
                    condicao = (Console.ReadLine());
                }
            } 
            
            while (condicao == "s");

            Console.ReadLine();
        }
    }
}
