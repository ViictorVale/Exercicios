using System;
using System.Globalization;
namespace Exercicio_13_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] produtos = new string[n];
            double[] precocompra = new double[n];
            double[] precovenda = new double[n];

            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                produtos[i] = (s[0]);
                precocompra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                precovenda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);

            }
      
            //descobrir lucros
            int lucroabaixo = 0;
            int lucroentre = 0;
            int lucroacima = 0;
            for (int i = 0; i < n; i++)
            {
                double diferenca = precovenda[i] - precocompra[i];
                double porcentagem = diferenca / precocompra[i] * 100.0;

                if (porcentagem < 10.0)
                {
                    lucroabaixo++;
                }
                else if(porcentagem <= 20.0)
                {
                    lucroentre++;
                }
                else
                {
                    lucroacima++;
                }
            }
            Console.WriteLine("Lucro abaixo de 10%: " + lucroabaixo);
            Console.WriteLine("Lucro entre 10% e 20%: " + lucroentre);
            Console.WriteLine("Lucro acima de 20%: " + lucroacima);

            //Descobrir o total de vendas e compras
            double totalcompras = 0.0;
            double totalvendas = 0.0;
            for (int i = 0; i < n; i++)
            {
                totalcompras = totalcompras + precocompra[i];
                totalvendas = totalvendas + precovenda[i];
            }

            //Descobrir lucro total
            double lucrototal = 0;
            for (int i = 0; i < n; i++)
            {
                lucrototal = totalvendas - totalcompras;
            }

            Console.WriteLine("Valor total de compra: " + totalcompras.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totalvendas.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucrototal.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
