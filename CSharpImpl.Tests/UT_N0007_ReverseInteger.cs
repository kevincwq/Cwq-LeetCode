using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N0007_ReverseInteger
    {
        static object[] TestCases =
        {
            new object[]{ 123, 321 },
            new object[]{ -123, -321 },
            new object[]{ 120, 21 },
            new object[]{ int.MinValue, 0 },
            new object[]{ int.MaxValue, 0}
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int x, int expected)
        {
            var so = new N0007_ReverseInteger.Solution1();
            var ans = so.Reverse(x);
            Assert.AreEqual(expected, ans);
        }

        [TestCaseSource(nameof(TestCases))]
        public void Solution2(int x, int expected)
        {
            var so = new N0007_ReverseInteger.Solution2();
            var ans = so.Reverse(x);
            Assert.AreEqual(expected, ans);
        }
    }
}