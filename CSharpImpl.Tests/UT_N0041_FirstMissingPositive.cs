using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N0041_FirstMissingPositive
    {
        static object[] TestCases =
        {
            new object[]{ new int[] { 1, 2, 0}, 3 },
            new object[]{ new int[] { 3, 4, -1, 1 }, 2 },
            new object[]{ new int[] { 7, 8, 9, 11, 12}, 1 },
            new object[]{ new int[] { 1, 2, 0, 1}, 3 }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] input, int expected)
        {
            var so = new N0041_FirstMissingPositive.Solution1();
            var ans = so.FirstMissingPositive(input);
            Assert.AreEqual(expected, ans);
        }

        [TestCaseSource(nameof(TestCases))]
        public void Solution2(int[] input, int expected)
        {
            var so = new N0041_FirstMissingPositive.Solution2();
            var ans = so.FirstMissingPositive(input);
            Assert.AreEqual(expected, ans);
        }
    }
}