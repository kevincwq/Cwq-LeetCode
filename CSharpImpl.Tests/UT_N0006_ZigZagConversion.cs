using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N0006_ZigZagConversion
    {
        static object[] TestCases =
        {
            new object[]{ "PAYPALISHIRING", 3, "PAHNAPLSIIGYIR" },
            new object[]{ "PAYPALISHIRING", 4, "PINALSIGYAHRPI" },
            new object[]{ "PAYPALISHIRING", 1, "PAYPALISHIRING" },
            new object[]{ "PAYPALISHIRING", 5, "PHASIYIRPLIGAN" },
            new object[]{ "PAYPALISHIRING", 6, "PRAIIYHNPSGAIL" },
            new object[]{ "PAYPALISHIRING", 2, "PYAIHRNAPLSIIG" },
            new object[]{ "PAYPALISHIRING", 0, "PAYPALISHIRING" },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(string s, int numRows, string expected)
        {
            var so = new N0006_ZigzagConversion.Solution1();
            var ans = so.Convert(s, numRows);
            Assert.AreEqual(expected, ans);
        }

        [TestCaseSource(nameof(TestCases))]
        public void Solution2(string s, int numRows, string expected)
        {
            var so = new N0006_ZigzagConversion.Solution2();
            var ans = so.Convert(s, numRows);
            Assert.AreEqual(expected, ans);
        }
    }
}