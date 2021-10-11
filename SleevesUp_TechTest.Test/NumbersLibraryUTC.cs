using System;
using Xunit;
using SleevesUp_TechTest;
using System.Collections.Generic;
using System.Linq;

namespace SleevesUp_TechTest.Test
{
    public class NumbersLibraryUTC : IDisposable
    {
        private IOrderedEnumerable<int> uniqueNumberList;

        public NumbersLibraryUTC()
        {
            uniqueNumberList = NumbersLibrary.GetUniqueNumbersInRange();
        }


        [Theory]
        [InlineData(12347, 1)]
        [InlineData(34569, 3)]
        public void FirstDigit_Test(int n, int expectedValue)
        {
            int firstDight = NumbersLibrary.FirstDigit(n);
            Assert.Equal(expectedValue, firstDight);
        }

        [Theory]
        [InlineData(12347, 7)]
        [InlineData(34569, 9)]
        public void LastDigit_Test(int n, int expectedValue)
        {
            int firstDight = NumbersLibrary.LastDigit(n);
            Assert.Equal(expectedValue, firstDight);
        }

        [Theory]
        [InlineData(12368, 86321)]
        public void ReverseNumber_Test(int n, int expectedValue)
        {
            int firstDight = NumbersLibrary.ReverseNumber(n);
            Assert.Equal(expectedValue, firstDight);
        }

        [Theory]
        [InlineData(11111, 0)]
        [InlineData(11112, 0)]
        [InlineData(53415, 0)]
        [InlineData(12345, 1)]
        public void Check_Repeated_Digit_Test(int n, int expectedValue)
        {
            int firstDight = NumbersLibrary.Check_Repeated_Digit(n);
            Assert.Equal(expectedValue, firstDight);
        }

        [Fact]
        public void ConvertNumberToArray_Test()
        {
            List<int> expectedValue = new List<int>() { 1, 2, 3, 6, 8 };
            int n = 12368;

            List<int> digits = NumbersLibrary.ConvertNumberToArray(n);
            Assert.Equal(expectedValue, digits);
        }

        [Theory]
        [InlineData(126)]
        public void GetUniqueNumbersInRange_Test(int totalCount)
        {
            Assert.Equal(totalCount, uniqueNumberList.Count());
        }

        [Fact]
        public void GetMinValueFromList_Test()
        {
            Assert.Equal(12345, NumbersLibrary.GetMinValueFromList(uniqueNumberList));
        }

        [Theory]
        [InlineData(2, 9, 23469)]
        [InlineData(3, 8, 34578)]
        public void GetValueFromList_Test(int startDigit, int lastDigit, int expectedValue)
        {
            List<int> someNumbers = new List<int>();
            someNumbers.Add(23469);
            someNumbers.Add(23468);
            someNumbers.Add(34578);
            someNumbers.Add(34579);
            someNumbers.Add(14579);
            someNumbers.Add(13461);

            int actualValue = NumbersLibrary.GetValueFromList(someNumbers.OrderBy(x => x), startDigit, lastDigit);
            Assert.Equal(expectedValue, actualValue);
        }

        public void Dispose()
        {
            uniqueNumberList = null;
        }
    }
}
