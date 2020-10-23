using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0018_4Sum
    {
        static object[] TestCases =
        {
            new object[]{ new int[] { 1, 0, -1, 0, -2, 2 }, 0, new List<IList<int>>() { new List<int> { -2, -1, 1, 2 }, new List<int> { -2, 0, 0, 2 }, new List<int> { -1, 0, 0, 1 } } },
            new object[]{ new int[] {}, 0, new List<IList<int>>() { } }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] input, int target, IList<IList<int>> expected)
        {
            var so = new N0018_4Sum.Solution1();
            var ans = so.FourSum(input, target);
            TestHelper.AreEqual(expected, ans);
        }
    }
}