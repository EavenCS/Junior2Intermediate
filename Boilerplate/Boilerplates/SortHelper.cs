using System.Diagnostics;

/// <summary>
/// Utility class for common operations like printing arrays and measuring execution time.
/// </summary>
namespace Boilerplate.Boilerplates
{
    public static class SortHelper
    {
        /// <summary>
        /// Prints the elements of an integer array to the console in a comma-separated format.
        /// </summary>
        /// <param name="array">The array to be printed</param>
        public static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }

        /// <summary>
        /// Measures the execution time of a given action in milliseconds.
        /// </summary>
        /// <param name="action">The action to measure</param>
        /// <returns>Execution time in milliseconds</returns>
        public static double MeasureExecutionTime(Action action)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action.Invoke();
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }
    }
}