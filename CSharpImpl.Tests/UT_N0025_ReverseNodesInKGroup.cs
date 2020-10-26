using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0025_ReverseNodesInKGroup
    {
        static object[] TestCases =
        {
            new object[]{ ListNode.FromValues(new int[] { 1, 2, 3, 4, 5 }), 2, ListNode.FromValues(new int[] { 2, 1, 4, 3, 5 }) },
            new object[]{ ListNode.FromValues(new int[] { 1, 2, 3, 4, 5 }), 3, ListNode.FromValues(new int[] { 3, 2, 1, 4, 5 }) },
            new object[]{ ListNode.FromValues(new int[] { 1, 2, 3, 4, 5 }), 1, ListNode.FromValues(new int[] { 1, 2, 3, 4, 5 }) },
            new object[]{ ListNode.FromValues(new int[] { 1 }), 1, ListNode.FromValues(new int[] { 1 }) },
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(ListNode input, int k, ListNode expected)
        {
            var so = new N0025_ReverseNodesInKGroup.Solution1();
            var ans = so.ReverseKGroup(input, k);
            Assert.IsTrue(Enumerable.SequenceEqual(ListNode.GetValues(expected), ListNode.GetValues(ans)));
        }
    }
}