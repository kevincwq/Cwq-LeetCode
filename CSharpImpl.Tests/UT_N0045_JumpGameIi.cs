using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N0045_JumpGameIi
    {
        static object[] TestCases =
        {
            new object[]{ new int[] { 2, 3, 1, 1, 4 }, 2 },
            new object[]{ new int[] { 2, 3, 1, 1, 4, 2, 1 }, 3 },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] input, int expected)
        {
            var so = new N0045_JumpGameIi.Solution1();
            var ans = so.Jump(input);
            Assert.AreEqual(expected, ans);
        }
    }
}