using System;

namespace Selection_Sort
{
    static class SelectionSort
    {
        public static int[] Sort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int min = i;
                int temp = 0;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[min] > a[j])
                        min = j;
                }

                temp = a[min];
                a[min] = a[i];
                a[i] = temp;
            }
            return a;
        }
    }
}
