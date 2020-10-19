using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0011_ContainerWithMostWater
    {
        static object[] TestCases =
        {
            new object[]{ new int[] { 1,8,6,2,5,4,8,3,7 },  49 },
            new object[]{ new int[] { 1,1 },  1 },
            new object[]{ new int[] { 4, 3, 2, 1, 4 },  16 },
            new object[]{ new int[] { 1,2,1 },  2 },
            new object[]{ new int[] { 1,8,6,2,5,4,8,3,7,1,8,6,2,15,14,8,13,7 },  120 },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] input, int expected)
        {
            var so = new N0011_ContainerWithMostWater.Solution1();
            var ans = so.MaxArea(input);
            Assert.AreEqual(expected, ans);
        }
    }
}