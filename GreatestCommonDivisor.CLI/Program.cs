using System;

namespace GreatestCommonDivisor.CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double b = Convert.ToDouble(Console.ReadLine());

            double gcd = GreatestCommonDivisor(a, b);

            Console.WriteLine($"The Greatest Common Divisor of {a} and {b} is {gcd}");
        }

        // GCD method
        private static double GreatestCommonDivisor(double a, double b)
        {
            if (a > b)
            {
                return EuclideanAlgorithm(a, b);
            }
            else
            {
                return EuclideanAlgorithm(b, a);
            }
        }

        // Euclidean Algorithm
        private static double EuclideanAlgorithm(double a, double b)
        {
            double remainder = a % b;

            if (remainder == 0)
            {
                return b;
            }
            else
            {
                return EuclideanAlgorithm(b, remainder);
            }
        }
    }
}
