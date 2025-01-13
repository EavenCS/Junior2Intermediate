using System;
using Boilerplate.Boilerplates;

namespace Bubblesort.CLI
{
    internal class Program
    {
        /// <summary>
        /// Entry point of the application that demonstrates the Bubble Sort algorithm.
        /// </summary>
        /// <param name="args">Command-line arguments</param>
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[] { 1, 3, 2, 5, 6, 4, 7, 9, 10 };

            Console.WriteLine("Unsorted Array:");
            SortHelper.PrintArray(unsortedArray);

            // Measure the time taken for Bubble Sort
            double timeTaken = SortHelper.MeasureExecutionTime(() =>
            {
                BubbleSort(unsortedArray);
            });

            Console.WriteLine("Sorted Array:");
            SortHelper.PrintArray(unsortedArray);

            Console.WriteLine($"Time taken for Bubble Sort: {timeTaken} ms");
        }

        /// <summary>
        /// Implements the Bubble Sort algorithm to sort an integer array in ascending order.
        /// </summary>
        /// <param name="array">The array to be sorted</param>
        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
