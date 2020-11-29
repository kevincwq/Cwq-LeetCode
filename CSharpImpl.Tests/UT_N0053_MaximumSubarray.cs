using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0053_MaximumSubarray
    {
        static object[] TestCases =
        {
            new object[]{ new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6 },
            new object[]{ new int[] { 4, -1, 2, 1 }, 6 },
            new object[]{ new int[] { -2, -1 }, -1 },
            new object[]{ new int[] { 4, -2, -1 }, 4 },
            new object[]{ new int[] { -1, -2, 2, -1, 4, -2, -1 }, 5 },
            new object[]{ new int[] { 1 }, 1 },
            new object[]{ new int[] { 0 }, 0 },
            new object[]{ new int[] { -1 }, -1 },
            new object[]{ new int[] { -2147483647 }, -2147483647 }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] input, int expected)
        {
            var so = new N0053_MaximumSubarray.Solution1();
            var ans = so.MaxSubArray(input);
            Assert.AreEqual(expected, ans);
        }

        [TestCaseSource(nameof(TestCases))]
        public void Solution2(int[] input, int expected)
        {
            var so = new N0053_MaximumSubarray.Solution2();
            var ans = so.MaxSubArray(input);
            Assert.AreEqual(expected, ans);
        }

        [TestCaseSource(nameof(TestCases))]
        public void Solution3(int[] input, int expected)
        {
            var so = new N0053_MaximumSubarray.Solution3();
            var ans = so.MaxSubArray(input);
            Assert.AreEqual(expected, ans);
        }
    }
}