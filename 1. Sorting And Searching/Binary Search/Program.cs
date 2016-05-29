using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        static int[] GenerateArray(int size)
        {
            int[] temp = new int[size];

            for (int i = 0; i < size; i++)
            {
                temp[i] = i;
            }
            return temp;
        }
        static void Main(string[] args)
        {
            int key, size, result;
            string parameters;
            Console.WriteLine("Binary Search");
            Console.WriteLine("Type - size:key");
            parameters = Console.ReadLine();

            size = Int32.Parse(parameters.Split(':')[0]);
            key = Int32.Parse(parameters.Split(':')[1]);

            result = BinarySearch.Search(GenerateArray(size), key);

            if (result != -1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{1} found at {0} position.", result, key);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} not found.", key);
            }
        }
    }
};
