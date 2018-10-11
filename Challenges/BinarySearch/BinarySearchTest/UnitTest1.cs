using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestReturnsIndexFour()
        {
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.Equal(4, Program.BinarySearch(temp, 5));
        }
    }
}
