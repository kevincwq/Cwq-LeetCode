using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0015_3Sum
    {
        static object[] TestCases =
        {
            new object[]{ new int[] { -1, 0, 1, 2, -1, -4 }, new List<IList<int>>() { new List<int> { -1, -1, 2}, new List<int> { -1, 0, 1} } },
            new object[]{ new int[] { -1, -1, 2, 2, 2, -1, 0, 1, 2, -1, -4 }, new List<IList<int>>() { new List<int> { -4, 2, 2}, new List<int> { -1, -1, 2}, new List<int> { -1, 0, 1} } },
            new object[]{ new int[] { }, new List<IList<int>>() { } },
            new object[]{ new int[] { 0 }, new List<IList<int>>() { } },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] input, IList<IList<int>> expected)
        {
            var so = new N0015_3Sum.Solution1();
            var ans = so.ThreeSum(input);
            Assert.IsTrue(TestHelper.AreEqual(expected, ans));
        }
    }
}