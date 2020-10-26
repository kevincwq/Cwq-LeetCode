using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0026_RemoveDuplicatesFromSortedArray
    {
        static object[] TestCases =
        {
            new object[]{ new int[] { 1, 1, 2 }, 2, new int[] { 1, 2 } },
            new object[]{ new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, new int[] { 0, 1, 2, 3, 4 } },
            new object[]{ new int[] { 1 }, 1, new int[] { 1 } },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] input, int len, int[] expected)
        {
            var so = new N0026_RemoveDuplicatesFromSortedArray.Solution1();
            var ans = so.RemoveDuplicates(input);
            Assert.AreEqual(len, ans);
            Assert.IsTrue(Enumerable.SequenceEqual(expected, input.Take(len)));
        }
    }
}