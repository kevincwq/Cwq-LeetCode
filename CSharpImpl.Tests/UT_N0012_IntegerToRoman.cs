using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0012_IntegerToRoman
    {
        static object[] TestCases =
        {
            new object[]{ 1, "I" },
            new object[]{ 2, "II" },
            new object[]{ 4, "IV" },
            new object[]{ 5, "V" },
            new object[]{ 7, "VII" },
            new object[]{ 9, "IX" },
            new object[]{ 10, "X" },
            new object[]{ 12, "XII" },
            new object[]{ 14, "XIV" },
            new object[]{ 15, "XV" },
            new object[]{ 17, "XVII" },
            new object[]{ 19, "XIX" },
            new object[]{ 23, "XXIII" },
            new object[]{ 39, "XXXIX" },
            new object[]{ 49, "XLIX" },
            new object[]{ 59, "LIX" },
            new object[]{ 99, "XCIX" },
            new object[]{ 149, "CXLIX" },
            new object[]{ 449, "CDXLIX" },
            new object[]{ 1994, "MCMXCIV" },
            new object[]{ 3999, "MMMCMXCIX" }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int input, string exptected)
        {
            var so = new N0012_IntegerToRoman.Solution1();
            var ans = so.IntToRoman(input);
            Assert.AreEqual(exptected, ans);
        }
    }
}