using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0020_ValidParentheses 
    {
        static object[] TestCases =
        {
            new object[]{ "()", true },
            new object[]{ "()[]{}", true },
            new object[]{ "(]", false },
            new object[]{ "([)]", false },
            new object[]{ "{[]}", true }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(string input, bool expected)
        {
            var so = new N0020_ValidParentheses.Solution1();
            var ans = so.IsValid(input);
            Assert.AreEqual(expected, ans);
        }
    }
}