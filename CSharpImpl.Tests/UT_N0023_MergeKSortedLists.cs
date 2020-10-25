using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0023_MergeKSortedLists
    {
        static object[] TestCases =
        {
            new object[]{ new [] { ListNode.FromValues(new[] { 1, 4, 5 }), ListNode.FromValues(new[] { 1, 3, 4 }), ListNode.FromValues(new[] { 2, 6 }) }, ListNode.FromValues(new[] { 1, 1, 2, 3, 4, 4, 5, 6 } )},
            new object[]{ new ListNode[] { }, ListNode.FromValues(new int[] { })},
            new object[]{ new ListNode[] { ListNode.FromValues(new int[] { }) }, ListNode.FromValues(new int[] { })},
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(ListNode[] input, ListNode expected)
        {
            var so = new N0023_MergeKSortedLists.Solution1();
            var ans = so.MergeKLists(input);
            Assert.IsTrue(Enumerable.SequenceEqual(ListNode.GetValues(expected), ListNode.GetValues(ans)));
        }
    }
}