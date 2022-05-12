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

        public BigInteger CalculateLargestPrimeNumber(BigInteger inputNumber)
        {
            //TODO
            //Check the input number is positive and greater than 1 (0 and 1 are not prime numbers) throw exception
            if (inputNumber <= 1)
            {
                Console.WriteLine($"{inputNumber}: {ErrorMessage.NumberOutOfRange}");
                return 0;
            }

            if (inputNumber > int.MaxValue)
            {

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

        private List<BigInteger> GetFactors(BigInteger inputNumber)
        {
            var factors = new List<BigInteger>();
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
