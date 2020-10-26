using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0027_RemoveElement
    {
        static object[] TestCases1 =
        {
            new object[]{ new int[] { 3, 2, 2, 3 }, 3, 2, new int[] { 2, 2 } },
            new object[]{ new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5, new int[] { 0, 1, 3, 0, 4 } },
            new object[]{ new int[] { 1 }, 1, 0, new int[] {  } }
        };

        static object[] TestCases2 =
{
            new object[]{ new int[] { 3, 2, 2, 3 }, 3, 2, new int[] { 2, 2 } },
            new object[]{ new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5, new int[] { 0, 1, 3, 0, 4 } },
            new object[]{ new int[] { 1 }, 1, 0, new int[] {  } }
        };

        [TestCaseSource(nameof(TestCases1))]
        public void Solution1(int[] input, int val, int len, int[] expected)
        {
            var so = new N0027_RemoveElement.Solution1();
            var ans = so.RemoveElement(input, val);
            Assert.AreEqual(len, ans);
            Assert.IsTrue(Enumerable.SequenceEqual(expected, input.Take(len)));
        }

        [TestCaseSource(nameof(TestCases2))]
        public void Solution2(int[] input, int val, int len, int[] expected)
        {
            var so = new N0027_RemoveElement.Solution2();
            var ans = so.RemoveElement(input, val);
            Assert.AreEqual(len, ans);
            Assert.IsTrue(Enumerable.SequenceEqual(expected.OrderBy(v => v), input.Take(len).OrderBy(v => v)));
        }
    }
}