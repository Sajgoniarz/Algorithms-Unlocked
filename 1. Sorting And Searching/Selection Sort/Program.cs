using System;

namespace Selection_Sort
{
    class Program
    {
        static void showArray(int[] a)
        {
            for (int k = 0; k < a.Length; k++)
            {
                Console.Write("{0},", a[k]);
            }
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Selection Sort");
            Console.WriteLine("Type - size");
            int size = Int32.Parse(Console.ReadLine());
            int[] a = new int[size];

            for (int i = 0; i < size; i++)
            {
                a[i] = r.Next(size * 5);
            }
            Console.Write("Before: "); showArray(a);
            Console.Write("\nAfter: "); showArray(SelectionSort.Sort(a));
            Console.Write("\n");
        }
    }
}
