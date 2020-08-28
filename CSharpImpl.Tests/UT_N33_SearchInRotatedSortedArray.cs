using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N33_SearchInRotatedSortedArray
    {
        static object[] TestCases =
        {
            new object[]{ new int[] { 1 }, 0 , -1},
            new object[]{ new int[] { 1, 3 }, 2, -1},
            new object[]{ new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4},
            new object[]{ new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1},
            new object[]{ new int[] { 1, 2, 4, 5, 6, 7, 0 }, 1, 0},
            new object[]{ new int[] { 1, 2, 4, 5, 6, 7, 0 }, 0, 6},
            new object[]{ new int[] { 1, 2, 4, 5, 6, 7, 0 }, 7, 5},
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] nums, int target, int ans)
        {
            var so = new N33_SearchInRotatedSortedArray.Solution1();
            var index = so.Search(nums, target);
            Assert.AreEqual(ans, index);
        }
    }
}