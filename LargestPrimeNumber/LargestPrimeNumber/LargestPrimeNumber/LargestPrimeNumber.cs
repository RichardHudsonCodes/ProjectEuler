using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestPrimeNumberNamespace
{
    public class LargestPrimeNumber
    {
        public LargestPrimeNumber()
        {
        }

        public int CalculateLargestPrimeNumber(int inputNumber)
        {
            //TODO
            //Check the input number is positive and greater than 1 (0 and 1 are not prime numbers) throw exception
            if (inputNumber <= 1)
            {
                Console.WriteLine($"{inputNumber}: {ErrorMessage.NumberOutOfRange}");
                return 0;
            }

            //Find all the factors of the input number. start by dividing by 2 and then incrementing upwards checking the quotient each time
            //once we have a list of factors. Determine whether they are prime. Start with the highest and stop
            //on the first prime number
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

        public List<int> GetFactors(int inputNumber)
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
