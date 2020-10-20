using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N0016_3SumClosest
    {
        static object[] TestCases =
        {
            new object[]{ new int[] {-1,2,1,-4}, 1, 2},
            new object[]{ new int[] {1,2,3}, 1, 6},
            new object[]{ new int[] {-1,2,1,-4,3,4,89,-5,-6}, -100, -15},
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] nums, int target, int expected)
        {
            var so = new N0016_3SumClosest.Solution1();
            var ans = so.ThreeSumClosest(nums, target);
            Assert.AreEqual(expected, ans);
        }

        [TestCaseSource(nameof(TestCases))]
        public void Solution2(int[] nums, int target, int expected)
        {
            var so = new N0016_3SumClosest.Solution2();
            var ans = so.ThreeSumClosest(nums, target);
            Assert.AreEqual(expected, ans);
        }
    }
}