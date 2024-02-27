using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 9, 1, 5, 6 };
            Console.WriteLine("Original array:");
            PrintArray(array);
            BubbleSortAlgorithm(array);
            Console.WriteLine("\nSorted array:");
            PrintArray(array);
            Console.ReadLine(  );
        }

        static void BubbleSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
