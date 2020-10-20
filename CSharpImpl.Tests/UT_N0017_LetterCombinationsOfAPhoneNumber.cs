using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0017_LetterCombinationsOfAPhoneNumber
    {
        static object[] TestCases =
        {
            new object[]{ "", new List<string>() },
            new object[]{ "2", new List<string>{ "a", "b", "c" } },
            new object[]{ "23", new List<string>{ "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" } },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(string input, IList<string> expected)
        {
            var so = new N0017_LetterCombinationsOfAPhoneNumber.Solution1();
            var ans = so.LetterCombinations(input);
            Assert.IsTrue(Enumerable.SequenceEqual(expected, ans));
        }

        [TestCaseSource(nameof(TestCases))]
        public void Solution2(string input, IList<string> expected)
        {
            var so = new N0017_LetterCombinationsOfAPhoneNumber.Solution2();
            var ans = so.LetterCombinations(input);
            Assert.IsTrue(Enumerable.SequenceEqual(expected, ans));
        }
    }
}