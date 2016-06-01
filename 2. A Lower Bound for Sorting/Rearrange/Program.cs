using System;
using Count_Keys_Equal;
using Count_Keys_Less;


namespace Rearrange
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
            Console.WriteLine("Rearrange");
            Console.WriteLine("n - size of array, m - number of diffrent keys");
            Console.WriteLine("Type n:m");
            string input = Console.ReadLine();

            int n = Int32.Parse(input.Split(':')[0]);
            int m = Int32.Parse(input.Split(':')[1]);

            int[] tab = BuildArray(n, m);
            int[] equal = CountKeysEqual.Count(tab, n, m);
            int[] less = CountKeysLess.Count(equal, m);
            int[] sorted = Rearrange.Sort(tab, less, n, m);

            Console.Write("Before :");
            for (int i = 0; i < n; i++)
                Console.Write("{0},", tab[i]);
            Console.Write("\nAfter : ");
            for (int i = 0; i < n; i++)
                Console.Write("{0},", sorted[i]);
            Console.WriteLine();
        }
    }
}
