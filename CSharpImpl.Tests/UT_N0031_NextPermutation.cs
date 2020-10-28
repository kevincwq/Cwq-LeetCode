using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0031_NextPermutation
    {
        static object[] TestCases =
        {
            new object[]{ new int[] {1, 2, 3}, new int[] {1, 3, 2 } },
            new object[]{ new int[] {3, 2, 1}, new int[] {1, 2, 3 } },
            new object[]{ new int[] {1, 1, 5}, new int[] {1, 5, 1 } },
            new object[]{ new int[] { 1, 2, 3, 4, 5, 4, 8, 9, 2, 3, 3, 4, 5, 9, 0, 1 }, new int[] { 1, 2, 3, 4, 5, 4, 8, 9, 2, 3, 3, 4, 5, 9, 1, 0 } },
            new object[]{ new int[] {1 }, new int[] {1 } },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] input, int[] expected)
        {
            var so = new N0031_NextPermutation.Solution1();
            so.NextPermutation(input);
            Assert.IsTrue(Enumerable.SequenceEqual(expected, input));
        }
    }
}