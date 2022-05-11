using System;
using LargestPrimeNumberNamespace;

namespace Programme
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("What number would you like to test?");
            int testNumber;
            int.TryParse(Console.ReadLine(), out testNumber);
            var largestPrimeNumber = new LargestPrimeNumber();

            var output = largestPrimeNumber.CalculateLargestPrimeNumber(testNumber);
            Console.WriteLine($"Largest prime number is {output}");
            goto start;
        }
    }
}
