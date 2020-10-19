using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N0005_LongestPalindromicSubstring
    {
        static object[] TestCases =
        {
            new object[]{ "babad", "bab" },
            new object[]{ "cbbd", "bb" },
            new object[]{ "ccc", "ccc" },
            new object[]{ "acccc", "cccc" }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(string s, string expected)
        {
            var so = new N0005_LongestPalindromicSubstring.Solution1();
            var ans = so.LongestPalindrome(s);
            Assert.AreEqual(expected, ans);
        }


        [TestCaseSource(nameof(TestCases))]
        public void Solution2(string s, string expected)
        {
            var so = new N0005_LongestPalindromicSubstring.Solution2();
            var ans = so.LongestPalindrome(s);
            Assert.AreEqual(expected, ans);
        }
    }
}