using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N0044_WildcardMatching
    {
        static object[] TestCases =
        {
            new object[]{ "", "", true },
            new object[]{ "", "*", true },
            new object[]{ "", "*?", false },
            new object[]{ "", "a", false },
            new object[]{ "a", "?", true },
            new object[]{ "a", "a", true },
            new object[]{ "", "*", true },
            new object[]{ "a", "", false },
            new object[]{ "aa", "*", true },
            new object[]{ "aaa", "a*", true },
            new object[]{ "aaa", "a*?", true },
            new object[]{ "aa", "a", false },
            new object[]{ "cb", "?a", false },
            new object[]{ "adceb", "*a*b", true },
            new object[]{ "acdcb", "a*c?b", false },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(string s, string p, bool expected)
        {
            var so = new N0044_WildcardMatching.Solution1();
            var ans = so.IsMatch(s, p);
            Assert.AreEqual(expected, ans);
        }
    }
}