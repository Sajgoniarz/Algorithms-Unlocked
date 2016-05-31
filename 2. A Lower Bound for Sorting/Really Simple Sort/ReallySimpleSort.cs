using System;


namespace Really_Simple_Sort
{
    static class ReallySimpleSort
    {
        public static int[] Sort(int[] a, int n)
        {
            int k = 0;
            int i = 0;

            for (i = 0; i < n; i++)
                if (a[i] == 1)
                    k++;

            for (i = 0; i < k; i++)
                a[i] = 1;

            for (i = k; i < n; i++)
                a[i] = 2;

            return a;
        }
    }
}
