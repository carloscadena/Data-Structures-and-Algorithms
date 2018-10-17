using System;
using Xunit;
using LinkedList.Classes;
using static LL_Kth_From_End.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 5)]
        [InlineData(1, 4)]
        [InlineData(2, 3)]
        [InlineData(3, 2)]
        [InlineData(4, 1)]

        public void KthFromEndTest(int k, object expected)
        {
            LList ll = MakeList();

            Assert.Equal(expected, KthFromEnd(k));

        }
    }
}
