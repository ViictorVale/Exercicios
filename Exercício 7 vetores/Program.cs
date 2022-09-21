using System;

namespace Exercício_7_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];

            string[] s = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }

            s = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++)
            {
                b[i] = int.Parse(s[i]);
            }
          
            int[] c = new int[n];
            for(int i = 0; i < n; i++)
            {
                c[i] = a[i] + b[i];
            }
            
            for(int i = 0; i < n; i++)
            {
                Console.Write(c[i] + " ");
            }
        }
    }
}
