using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
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
            Console.WriteLine("Merge Sort");
            Console.WriteLine("Type - size");
            int size = Int32.Parse(Console.ReadLine());
            int[] a = new int[size];

            for (int i = 0; i < size; i++)
            {
                a[i] = r.Next(size * 5);
            }
            Console.Write("Before: "); showArray(a);
            Console.Write("\nAfter: "); showArray(MergeSort.Sort(a, 0, a.Length - 1));
            Console.Write("\n");
        }
    }
}
