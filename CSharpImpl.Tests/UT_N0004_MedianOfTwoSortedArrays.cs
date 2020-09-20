using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N0004_MedianOfTwoSortedArrays
    {
        static object[] TestCases =
        {
            new object[]{ new[] {1, 3 }, new[] { 2 }, 2d },
            new object[]{ new[] {1, 2 }, new[] { 3, 4 }, 2.5d },
            new object[]{ new[] {0, 0 }, new[] { 0, 0 }, 0d },
            new object[]{ new int[] { }, new[] { 1 }, 1d },
            new object[]{ new[] { 2 }, new int[] {  }, 2d }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] A, int[] B, double exptected)
        {
            var so = new N0004_MedianOfTwoSortedArrays.Solution1();
            var ans = so.FindMedianSortedArrays(A, B);
            Assert.AreEqual(exptected, ans);
        }
    }
}