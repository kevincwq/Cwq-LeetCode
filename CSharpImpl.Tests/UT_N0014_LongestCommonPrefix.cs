using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0014_LongestCommonPrefix 
    {
        static object[] TestCases =
        {
            new object[]{ new string[] { "flower", "flow", "flight" }, "fl" },
            new object[]{ new string[] { "dog", "racecar", "car" }, "" },
            new object[]{ new string[] { }, "" },
            new object[]{ new string[] { "abc", "" }, "" },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(string[] input, string expected)
        {
            var so = new N0014_LongestCommonPrefix.Solution1();
            var ans = so.LongestCommonPrefix(input);
            Assert.AreEqual(expected, ans);
        }
    }
}