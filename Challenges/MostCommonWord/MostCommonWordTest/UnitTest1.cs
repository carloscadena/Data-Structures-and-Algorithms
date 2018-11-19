using System;
using Xunit;
using static MostCommonWord.Program;

namespace MostCommonWordTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("In a galaxy far far away", "far")]
        [InlineData("Taco cat ate a taco taco", "taco")]
        [InlineData("No Try not Do or do not There is no try", "do")]
        public void CorrectWordIsReturnedTest(string input, string expected)
        {
            Assert.True(FindMostCommonWord(input) == expected);

        }
    }
}
