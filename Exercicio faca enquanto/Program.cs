using System;
using System.Globalization;
namespace Exercicio_faca_enquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            char condicao;
            do
            {
                Console.Write("Digite a temperatura em Celsius: ");
                double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double F = 9 * C / 5 + 32;
                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja repetir (s/n)? ");
                condicao = char.Parse(Console.ReadLine());
            } 
            while (condicao == 's');

            Console.ReadLine();
        }
    }
}
