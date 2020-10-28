using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N0029_DivideTwoIntegers
    {
        static object[] TestCases =
        {
            new object[]{ 10, 3, 3 },
            new object[]{ 7, -3, -2 },
            new object[]{ 0, 1, 0 },
            new object[]{ 1, 1, 1 },
            new object[]{ int.MaxValue, 1, int.MaxValue },
            new object[]{ int.MinValue, 1, int.MinValue },
            new object[]{ int.MaxValue,  int.MaxValue, 1 },
            new object[]{ int.MinValue,  int.MinValue, 1 },
            new object[]{ int.MinValue,  int.MaxValue, -1 },
            new object[]{ int.MaxValue,  int.MinValue, 0 },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int dividend, int divisor, int expected)
        {
            var so = new N0029_DivideTwoIntegers.Solution1();
            var ans = so.Divide(dividend, divisor);
            Assert.AreEqual(expected, ans);
        }
    }
}