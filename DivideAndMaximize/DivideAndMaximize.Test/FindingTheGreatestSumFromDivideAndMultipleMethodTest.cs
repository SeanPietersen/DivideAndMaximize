using DivideAndMaximize.App;
using System;
using Xunit;

namespace DivideAndMaximize.Test
{
    public class FindingTheGreatestSumFromDivideAndMultipleMethodTest
    {
        [Theory]
        [InlineData(10, new long[] { 10 })]
        [InlineData(13, new long[] { 3, 4 })]
        [InlineData(50, new long[] { 6, 4, 2 })]
        [InlineData(44, new long[] { 6, 4, 5 })]
        [InlineData(46, new long[] { 1, 2, 3, 4, 5 })]
        [InlineData(68, new long[] { 14, 9, 26 })]
        [InlineData(371842558, new long[] { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 })]

        public void DivideAndMultiplyMethodTest(int expected, long[] numbers)
        {
            //Arrange
            IFindingTheGreatestSumFromDivideAndMultipleMethod findingTheGreatestSumFromDivideAndMultipleMethod = 
                new FindingTheGreatestSumFromDivideAndMultipleMethod();

            //Act
            var actual = findingTheGreatestSumFromDivideAndMultipleMethod.DivideAndMultiplyMethod(numbers);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
