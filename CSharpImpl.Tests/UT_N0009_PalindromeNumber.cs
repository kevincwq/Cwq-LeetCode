using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0009_PalindromeNumber
    {
        static object[] TestCases =
        {
            new object[]{ 121, true },
            new object[]{ -121, false },
            new object[]{ 10, false },
            new object[]{ -101, false },
            new object[]{ 1, true}
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int input, bool exptected)
        {
            var so = new N0009_PalindromeNumber.Solution1();
            var ans = so.IsPalindrome(input);
            Assert.AreEqual(exptected, ans);
        }

        [TestCaseSource(nameof(TestCases))]
        public void Solution2(int input, bool exptected)
        {
            var so = new N0009_PalindromeNumber.Solution2();
            var ans = so.IsPalindrome(input);
            Assert.AreEqual(exptected, ans);
        }
    }
}