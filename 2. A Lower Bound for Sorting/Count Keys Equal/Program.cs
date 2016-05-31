using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Keys_Equal
{
    class Program
    {
        static int[] BuildArray(int n, int m)
        {
            Random r = new Random();
            int[] temp = new int[n];

            for (int i = 0; i < n; i++)
                temp[i] = r.Next(0, m);

            return temp;
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Count equal keys");
            Console.WriteLine("n - size of array, m - number of diffrent keys");
            Console.WriteLine("Type n:m");
            string input = Console.ReadLine();

            int n = Int32.Parse(input.Split(':')[0]);
            int m = Int32.Parse(input.Split(':')[1]);

            int[] tab = BuildArray(n, m);
            int[] counted = CountKeysEqual.Count(tab, n, m);

            Console.Write("In :");
            for (int i = 0; i < n; i++)
                Console.Write("{0},", tab[i]);
            Console.WriteLine();
            for(int i = 0; i < m; i++)
                Console.WriteLine("{0} occurs {1} times.",i,counted[i]);
        }
    }
}
