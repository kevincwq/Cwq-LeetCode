using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N0042_TrappingRainWater
    {
        static object[] TestCases =
        {
            new object[]{ new int[] { 0, 1 }, 0 },
            new object[]{ new int[] { 0, 1, 0, 2, 0, 1, 0 }, 2 },
            new object[]{ new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6 },
            new object[]{ new int[] { 1, 3, 0, 9, 3, 1, 5, 7, 0, 0, 1, 2, 3 }, 24 }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] input, int expected)
        {
            var so = new N0042_TrappingRainWater.Solution1();
            var ans = so.Trap(input);
            Assert.AreEqual(expected, ans);
        }

        [TestCaseSource(nameof(TestCases))]
        public void Solution2(int[] input, int expected)
        {
            var so = new N0042_TrappingRainWater.Solution2();
            var ans = so.Trap(input);
            Assert.AreEqual(expected, ans);
        }
    }
}