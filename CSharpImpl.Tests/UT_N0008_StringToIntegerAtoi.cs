using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0008_StringToIntegerAtoi 
    {
        static object[] TestCases =
        {
            new object[]{ "42", 42 },
            new object[]{ " -42", -42 },
            new object[]{ "4193 with words", 4193 },
            new object[]{ "words and 987", 0 },
            new object[]{ "-91283472332", -2147483648 },
            new object[]{ " -a89", 0 },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(string input, int expected)
        {
            var so = new N0008_StringToIntegerAtoi.Solution1();
            var ans = so.MyAtoi(input);
            Assert.AreEqual(expected, ans);
        }
    }
}