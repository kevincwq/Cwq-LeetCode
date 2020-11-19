using NUnit.Framework;
using System.Collections.Generic;

namespace CSharpImpl.Tests
{
    public class UT_N0046_Permutations
    {
        static object[] TestCases =
        {
            new object[]{ new int[] { }, new List<IList<int>> { } },
            new object[]{ new int[] { 1 }, new List<IList<int>> { 
                new List<int> { 1 }
            } },
            new object[]{ new int[] { 1, 2 }, new List<IList<int>> { 
                new List<int> { 1, 2}, 
                new List<int> { 2, 1} 
            } },
            new object[]{ new int[] { 1, 2, 3 }, new List<IList<int>> {
                new List<int> { 1, 2, 3 },
                new List<int> { 2, 1, 3 },
                new List<int> { 1, 3, 2 },
                new List<int> { 3, 1, 2 },
                new List<int> { 2, 3, 1 },
                new List<int> { 3, 2, 1 },
            } },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] input, IList<IList<int>> expected)
        {
            var so = new N0046_Permutations.Solution1();
            var ans = so.Permute(input);
            Assert.IsTrue(TestHelper.AreEqual(expected, ans));
        }
    }
}