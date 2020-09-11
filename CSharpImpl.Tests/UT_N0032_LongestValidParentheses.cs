using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N0032_LongestValidParentheses
    {
        static object[] TestCases =
        {
            new object[]{"", 0},
            new object[]{"(()", 2},
            new object[]{")()())", 4 },
            new object[]{"())))(()()()())))(((((()()((()()((())()))))))", 26 }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(string s, int length)
        {
            var so = new N0032_LongestValidParentheses.Solution1();
            var len = so.LongestValidParentheses(s);
            Assert.AreEqual(length, len);
        }

        [TestCaseSource(nameof(TestCases))]
        public void Solution2(string s, int length)
        {
            var so = new N0032_LongestValidParentheses.Solution2();
            var len = so.LongestValidParentheses(s);
            Assert.AreEqual(length, len);
        }

        [TestCaseSource(nameof(TestCases))]
        public void Solution3(string s, int length)
        {
            var so = new N0032_LongestValidParentheses.Solution3();
            var len = so.LongestValidParentheses(s);
            Assert.AreEqual(length, len);
        }

        [TestCaseSource(nameof(TestCases))]
        public void Solution4(string s, int length)
        {
            var so = new N0032_LongestValidParentheses.Solution4();
            var len = so.LongestValidParentheses(s);
            Assert.AreEqual(length, len);
        }
    }
}