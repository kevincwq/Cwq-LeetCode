using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N0043_MultiplyStrings
    {
        static object[] TestCases =
        {
            new object[]{ "2", "3", "6" },
            new object[]{ "123", "456", "56088" },
            new object[]{ "7348623809286734846836734", "62384682690274510474578268456891202367456", "458441564552549302855459865361122118808493457788499734893506928704" }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(string num1, string num2, string expected)
        {
            var so = new N0043_MultiplyStrings.Solution1();
            var ans = so.Multiply(num1, num2);
            Assert.AreEqual(expected, ans);
        }
    }
}