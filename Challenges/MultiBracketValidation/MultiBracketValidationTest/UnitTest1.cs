using System;
using Xunit;
using StacksAndQueues.Classes;
using static MultiBracketValidation.Program;

namespace MultiBracketValidationTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Test that unbalanced brackets returns false
        /// </summary>
        /// <param name="brackets">string to be tested as method parameter</param>
        [Theory]
        [InlineData("{(()[]}")]
        [InlineData("{()([]}")]
        [InlineData("{[{((()[]}}}]")]
        public void UnbalancedBracketsReturnsFalseTest(string brackets)
        {
            Assert.False(MultiBrackValidation(brackets));
        }
        
        /// <summary>
        /// Test that unbalanced brackets returns true
        /// </summary>
        /// <param name="brackets">string to be tested as method parameter</param>
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
