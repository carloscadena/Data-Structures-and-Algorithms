using System;
using Xunit;
using StacksAndQueues.Classes;
using static MultiBracketValidation.Program;

namespace MultiBracketValidationTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{(()[]}")]
        [InlineData("{()([]}")]
        [InlineData("{[{((()[]}}}]")]
        public void UnbalancedBracketsReturnsFalseTest(string brackets)
        {
            Assert.False(MultiBrackValidation(brackets));
        }

        [Theory]
        [InlineData("({[]}[])")]
        [InlineData("[]{}()")]
        [InlineData("{()()({})}")]
        public void BalancedBracketsReturnsTrueTest(string brackets)
        {
            Assert.True(MultiBrackValidation(brackets));
        }
    }
}
