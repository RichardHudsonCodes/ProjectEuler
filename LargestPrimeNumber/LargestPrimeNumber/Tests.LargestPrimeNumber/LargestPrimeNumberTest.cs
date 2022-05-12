using System;
using Xunit;

namespace LargestPrimeNumberNamespace
{
    public class LargestPrimeNumberTest
    {
        public LargestPrimeNumber _largestPrimeNumber = new LargestPrimeNumber();

        [Fact]
        public void CalculateLargestPrimeNumber_input_6()
        {
            //arrange
            var inputNumber = 6;
            //action
            var largestPrimeNumber = _largestPrimeNumber.CalculateLargestPrimeNumber(inputNumber);
            //assert
            Assert.True(largestPrimeNumber == 3);
        }

        [Fact]
        public void CalculateLargestPrimeNumber_input_1()
        {
            //arrange
            var inputNumber = 1;
            //action
            var largestPrimeNumber = _largestPrimeNumber.CalculateLargestPrimeNumber(inputNumber);
            //assert
           
            Assert.True(largestPrimeNumber == 0);
        }
    }
}
