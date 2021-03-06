﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    static class InsertionSort
    {
        public static int[] Sort(int[] a)
        {
            for(int i = 1; i < a.Length; i++)
            {
                int key = a[i];
                int j = i-1;

                while(j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    --j;
                }
                a[j + 1] = key;               
            }
            return a;
        }
    }
}
