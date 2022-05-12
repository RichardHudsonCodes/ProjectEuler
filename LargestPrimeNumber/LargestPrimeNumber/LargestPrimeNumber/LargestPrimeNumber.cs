using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace LargestPrimeNumberNamespace
{
    public class LargestPrimeNumber
    {
        public LargestPrimeNumber()
        {
        }

        public int CalculateLargestPrimeNumber(int inputNumber)
        { 
            inputNumber = ValidateInput(inputNumber);
            if (inputNumber == 0)
            {
                return inputNumber;
            }

            var factors = GetFactors(inputNumber);
            factors = factors.OrderByDescending(i => i).ToList();
             

            foreach (var factor in factors)
            {
                var factorOfFactor = GetFactors(factor);
                if (factorOfFactor.Count == 2)
                {
                    return factor;
                }
            }         
            return 0;
        }

        private int ValidateInput(int inputNumber)
        {
            if (inputNumber <= 1)
            {
                Console.WriteLine($"{inputNumber}: {ErrorMessage.NumberOutOfRange}");
                return 0;
            }

            if (inputNumber >= int.MaxValue)
            {
                Console.WriteLine($"{inputNumber}: {ErrorMessage.NumberOutTooLarge}");
                return 0;
            }
            return inputNumber;
        }

        private List<int> GetFactors(int inputNumber)
        {
            var factors = new List<int>();
            for (int i = 1; i <= inputNumber; i++)
            {
                if (inputNumber % i == 0)
                {
                    factors.Add(i);
                }
            }

            return factors; 
        }
    }

}
