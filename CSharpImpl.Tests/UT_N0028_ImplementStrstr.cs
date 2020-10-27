using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N0028_ImplementStrstr 
    {
        static object[] TestCases =
        {
            new object[]{ "hello", "ll", 2 },
            new object[]{ "aaaaa", "bba", -1 },
            new object[]{ "", "", 0 },
            new object[]{ "", "abc", -1 },
            new object[]{ "aaaaabba", "bba", 5 },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(string haystack, string needle, int expected)
        {
            var so = new N0028_ImplementStrstr.Solution1();
            var ans = so.StrStr(haystack, needle);
            Assert.AreEqual(expected, ans);
        }
    }
}