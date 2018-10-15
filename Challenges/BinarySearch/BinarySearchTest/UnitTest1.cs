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
        //first index
       [Fact]
        public void TestReturnsIndexZero()
        {
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.Equal(0, Program.BinarySearch(temp, 1));
        }
        [Fact]
        //last index
        public void TestReturnsIndexNine()
        {
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.Equal(9, Program.BinarySearch(temp, 10));
        }
        [Fact]
        public void TestReturnsIndexfive()
        {
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.Equal(5, Program.BinarySearch(temp, 6));
        }
        [Fact]
        public void TestReturnsNegativeOne()
        {
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.Equal(-1, Program.BinarySearch(temp, 11));
        }

    }
}
