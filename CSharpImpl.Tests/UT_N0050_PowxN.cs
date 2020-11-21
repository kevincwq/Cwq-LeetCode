using NUnit.Framework;
using System;

namespace CSharpImpl.Tests
{
    public class UT_N0050_PowxN
    {
        static object[] TestCases =
        {
            new object[]{ 0d, int.MaxValue, 0},
            new object[]{ 1d, int.MaxValue, 1},
            new object[]{ 1d, int.MinValue, 1},
            new object[]{ -1d, int.MaxValue, -1},
            new object[]{ -1d, int.MaxValue-1, 1},
            new object[]{ -1d, int.MinValue, 1},
            new object[]{ -1d, int.MinValue+1, -1},
            new object[]{ 2.00000d, 10, 1024.00000d },
            new object[]{ 2.00000d, 11, 2048.00000d },
            new object[]{ 2.10000d, 3, 9.26100d },
            new object[]{ 2.00000d, -2, 0.25000d }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(double x, int n, double expected)
        {
            var so = new N0050_PowxN.Solution1();
            var ans = so.MyPow(x, n);
            Assert.AreEqual(expected, Math.Round(ans, 5));
        }
    }
}