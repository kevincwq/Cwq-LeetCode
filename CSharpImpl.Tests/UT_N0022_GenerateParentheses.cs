using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0022_GenerateParentheses
    {
        static object[] TestCases =
        {
            new object[]{ 1, new List<string> {"()"}},
            new object[]{ 2, new List<string> {"(())", "()()"}},
            new object[]{ 3, new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" } }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int input, IList<string> expected)
        {
            var so = new N0022_GenerateParentheses.Solution1();
            var ans = so.GenerateParenthesis(input);
            Assert.IsTrue(Enumerable.SequenceEqual(expected, ans));
        }
    }
}