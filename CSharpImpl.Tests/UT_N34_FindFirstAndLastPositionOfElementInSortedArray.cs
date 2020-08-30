using NUnit.Framework;
using System;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N34_FindFirstAndLastPositionOfElementInSortedArray
    {
        static object[] TestCases =
        {
            new object[]{ new [] { 5, 7, 7, 8, 8, 10 }, 8 , new[] { 3, 4 } },
            new object[]{ new [] { 5, 7, 7, 8, 8, 10 }, 6 , new[] { -1, -1 } },
            new object[]{ new [] { 5, 5, 5, 5, 5, 5, 5, 5 }, 5 , new[] { 0, 7 } },
            new object[]{ new [] { 1 }, 1 , new[] { 0, 0 } },
            new object[]{ new [] { 1, 1 }, 1 , new[] { 0, 1 } },
            new object[]{ new int[] { }, 1 , new[] { -1, -1 } },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] nums, int target, int[] ans)
        {
            var so = new N34_FindFirstAndLastPositionOfElementInSortedArray.Solution1();
            var index = so.SearchRange(nums, target);
            Assert.IsTrue(Enumerable.SequenceEqual(ans, index));
        }
    }
}