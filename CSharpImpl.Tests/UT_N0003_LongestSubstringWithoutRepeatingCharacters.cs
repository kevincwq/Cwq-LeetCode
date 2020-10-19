using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N0003_LongestSubstringWithoutRepeatingCharacters
    {
        static object[] TestCases =
        {
            new object[]{ "abcabcbb", 3 },
            new object[]{ "bbbbb", 1 },
            new object[]{ "pwwkew", 3 },
            new object[]{ "", 0 },
            new object[]{ " ", 1 },
            new object[]{ "aab", 2},
            new object[]{ "dvdf", 3}
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(string s, int expected)
        {
            var so = new N0003_LongestSubstringWithoutRepeatingCharacters.Solution1();
            var ans = so.LengthOfLongestSubstring(s);
            Assert.AreEqual(expected, ans);
        }
    }
}