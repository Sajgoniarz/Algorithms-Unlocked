using System;

namespace Counting_Sort
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
                Console.WriteLine("Counting Sort");
                Console.WriteLine("n - size of array, m - number of diffrent keys");
                Console.WriteLine("Type n:m");
                string input = Console.ReadLine();

                int n = Int32.Parse(input.Split(':')[0]);
                int m = Int32.Parse(input.Split(':')[1]);

                int[] tab = BuildArray(n, m);
                int[] sorted = CountingSort.Sort(tab, n, m);

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
