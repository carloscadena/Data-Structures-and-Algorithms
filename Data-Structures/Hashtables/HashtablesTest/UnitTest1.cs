using Hashtables.Classes;
using System;
using Xunit;

namespace HashtablesTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Hash table add method test
        /// </summary>
        [Fact]
        public void AddToHashtableTest()
        {
            Hashtable table = new Hashtable();
            table.Add("cheese", "burger");

            Assert.Equal("burger", table.Find("cheese"));
        }

        /// <summary>
        /// Hash table contains method test
        /// </summary>
        [Fact]
        public void ContainsReturnsCorrectBool()
        {
            Hashtable table = new Hashtable();
            table.Add("swiss", "cheese");

            Assert.True(table.Contains("swiss"));
        }

        /// <summary>
        /// Test that the find method correctly returns value from bucket with multiple nodes
        /// </summary>
        [Fact]
        public void FindMethodOnCollisionBucketTest()
        {
            Hashtable table = new Hashtable();
            table.Add("cat", "mouse");
            table.Add("tac", "ouch");

            Assert.Equal("ouch", (string)table.Find("tac"));
        }

        /// <summary>
        /// Test that the contain method returns correct bool from bucket with multiple nodes
        /// </summary>
        [Fact]
        public void ContainsMethodOnCollisionBucketTest()
        {
            Hashtable table = new Hashtable();
            table.Add("cat", "sandwich");
            table.Add("tac", "pointy");

            Assert.True(table.Contains("tac"));
        }
    }
}
