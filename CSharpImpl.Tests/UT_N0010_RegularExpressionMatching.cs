using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0010_RegularExpressionMatching
    {
        static object[] TestCases =
        {
            new object[]{ "", "", true },
            new object[]{ "aa", "a", false },
            new object[]{ "aa", "a*", true },
            new object[]{ "aa", "a.", true },
            new object[]{ "aa", "..", true },
            new object[]{ "aa", "aa", true },
            new object[]{ "ab", ".*", true },
            new object[]{ "", ".*", true },
            new object[]{ "", ".", false },
            new object[]{ "", "*", false },
            new object[]{ "a", "", false },
            new object[]{ "a", "ab*a", false },
            new object[]{ "aaa", "aaaa", false },
            new object[]{ "mississippi", "mis*is*p*.", false },
            new object[]{ "aab", "c*a*b", true },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(string s, string p, bool exptected)
        {
            var so = new N0010_RegularExpressionMatching.Solution1();
            var ans = so.IsMatch(s, p);
            Assert.AreEqual(exptected, ans);
        }

        [TestCaseSource(nameof(TestCases))]
        public void Solution2(string s, string p, bool exptected)
        {
            var so = new N0010_RegularExpressionMatching.Solution2();
            var ans = so.IsMatch(s, p);
            Assert.AreEqual(exptected, ans);
        }

        [TestCaseSource(nameof(TestCases))]
        public void Solution3(string s, string p, bool exptected)
        {
            var so = new N0010_RegularExpressionMatching.Solution3();
            var ans = so.IsMatch(s, p);
            Assert.AreEqual(exptected, ans);
        }
    }
}