using Boilerplate.Boilerplates;

namespace SelectionSort.CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[] { 1, 3, 2, 5, 6, 4, 7, 9, 10 };



            Console.WriteLine("Unsorted Array:");
            SortHelper.PrintArray(unsortedArray);

            // Measure the time taken for Bubble Sort
            double timeTaken = SortHelper.MeasureExecutionTime(() =>
            {
                SelectionSort(unsortedArray);
            });

            Console.WriteLine("Sorted Array:");
            SortHelper.PrintArray(unsortedArray);

            Console.WriteLine($"Time taken for Selection Sort: {timeTaken} ms");

        }
        static void SelectionSort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }
    }
}
