using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0030_SubstringWithConcatenationOfAllWords
    {
        static object[] TestCases =
        {
            new object[]{ "barfoothefoobarman", new string[] { "foo", "bar" }, new List<int> { 0, 9} },
            new object[]{ "wordgoodgoodgoodbestword", new string[] { "word", "good", "best", "word" }, new List<int> { } },
            new object[]{ "barfoofoobarthefoobarman", new string[] { "bar", "foo", "the" }, new List<int> { 6, 9, 12} },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(string s, string[] words, IList<int> expected)
        {
            var so = new N0030_SubstringWithConcatenationOfAllWords.Solution1();
            var ans = so.FindSubstring(s, words);
            Assert.IsTrue(Enumerable.SequenceEqual(expected, ans));
        }

        [TestCaseSource(nameof(TestCases))]
        public void Solution2(string s, string[] words, IList<int> expected)
        {
            var so = new N0030_SubstringWithConcatenationOfAllWords.Solution2();
            var ans = so.FindSubstring(s, words);
            Assert.IsTrue(Enumerable.SequenceEqual(expected, ans));
        }
    }
}