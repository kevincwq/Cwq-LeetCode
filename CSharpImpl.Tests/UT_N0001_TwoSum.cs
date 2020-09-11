using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0001_TwoSum
    {
        static object[] TestCases =
        {
            new object[]{ new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 } },
            new object[]{ new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 } },
            new object[]{ new int[] { 3, 3}, 6, new int[] { 0, 1 } },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] nums, int target, int[] exptected)
        {
            var so = new N0001_TwoSum.Solution1();
            var ans = so.TwoSum(nums, target);
            Assert.IsTrue(Enumerable.SequenceEqual(exptected, ans));
        }
    }
}