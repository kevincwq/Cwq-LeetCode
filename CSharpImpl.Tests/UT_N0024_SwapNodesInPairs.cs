using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0024_SwapNodesInPairs
    {
        static object[] TestCases =
        {
            new object[]{ ListNode.FromValues(new int[] { }), ListNode.FromValues(new int[] { }) },
            new object[]{ ListNode.FromValues(new[] { 1 }), ListNode.FromValues(new[] { 1 }) },
            new object[]{ ListNode.FromValues(new[] { 1, 2, 3, 4 }), ListNode.FromValues(new[] { 2, 1, 4, 3}) }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(ListNode input, ListNode expected)
        {
            var so = new N0024_SwapNodesInPairs.Solution1();
            var ans = so.SwapPairs(input);
            Assert.IsTrue(Enumerable.SequenceEqual(ListNode.GetValues(expected), ListNode.GetValues(ans)));
        }
    }
}