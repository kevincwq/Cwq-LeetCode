using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0040_CombinationSumIi
    {
        static object[] TestCases =
        {
            new object[]{ new int[]{2, 2, 3, 3, 6, 7, 7}, 7, new List<IList<int>>() { new List<int>() { 2, 2, 3 }, new List<int>(){ 7 } } },
            new object[]{ new int[]{2, 3, 5}, 8, new List<IList<int>>() {new List<int>(){ 3, 5 } } },
            new object[]{ new int[]{2, 2, 4, 5, 6, 6, 7, 8, 9, 10, 10, 11, 12, 13 }, 15, new List<IList<int>>() {
                new List<int>() { 2, 2, 4, 7 },
                new List<int>() { 2, 2, 5, 6 },
                new List<int>() { 2, 2, 11 },
                new List<int>() { 2, 4, 9 },
                new List<int>() { 2, 5, 8 },
                new List<int>() { 2, 6, 7 },
                new List<int>() { 2, 13 },
                new List<int>() { 4, 5, 6 },
                new List<int>() { 4, 11 }, 
                new List<int>() { 5, 10 }, 
                new List<int>() { 6, 9 }, 
                new List<int>() { 7, 8 }  
            } }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] candidates, int target, IList<IList<int>> expected)
        {
            var so = new N0040_CombinationSumIi.Solution1();
            var ans = so.CombinationSum2(candidates, target);
            Assert.IsTrue(TestHelper.AreEqual(expected, ans));
        }
    }
}