using System;
using Xunit;
using static EeneyMeenyMineyMoe.Program;

namespace EeneyMeenyMineyMoeTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new string[] { "Carlos", "Jimmy", "Jeff", "Tre", "Aaron", "Kris" }, 3, "Carlos")]
        [InlineData(new string[] { "Carlos", "Jimmy", "Jeff", "Tre", "Aaron", "Kris" }, 2, "Aaron")]
        [InlineData(new string[] { "Carlos", "Jimmy", "Jeff", "Tre", "Aaron", "Kris" }, 4, "Aaron")]
        public void CheckCorrectNameIsReturnedTest(string[] names, int n, string expected)
        {
            Assert.Equal(EeneyMeenyMineyMoeMethod(names, n), expected);
        }
    }
}
