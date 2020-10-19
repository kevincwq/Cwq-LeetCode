using NUnit.Framework;
using System;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0035_SearchInsertPosition
    {
        static object[] TestCases =
        {
            new object[]{ new int[] { 1 }, 0 , 0},
            new object[]{ new int[] { 1, 3, 5, 6 }, 5, 2},
            new object[]{ new int[] { 1, 3, 5, 6 }, 7, 4},
            new object[]{ new int[] { 1, 3, 5, 6 }, 0, 0},
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] nums, int target, int expected)
        {
            var so = new N0035_SearchInsertPosition.Solution1();
            var ans = so.SearchInsert(nums, target);
            Assert.AreEqual(expected, ans);
        }
    }
}