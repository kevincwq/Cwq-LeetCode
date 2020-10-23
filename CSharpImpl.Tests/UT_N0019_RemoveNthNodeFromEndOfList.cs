using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0019_RemoveNthNodeFromEndOfList
    {
        static object[] TestCases =
        {
            new object[]{ ListNode.FromValues(new[] { 1, 2, 3, 4, 5 }), 2, ListNode.FromValues(new[] { 1, 2, 3, 5 } )},
            new object[]{ ListNode.FromValues(new[] { 1 }), 1, ListNode.FromValues(new int[] {} )},
            new object[]{ ListNode.FromValues(new[] { 1, 2}), 1, ListNode.FromValues(new[] { 1 } )},
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(ListNode input, int n, ListNode expected)
        {
            var so = new N0019_RemoveNthNodeFromEndOfList.Solution1();
            var ans = so.RemoveNthFromEnd(input, n);
            Assert.IsTrue(Enumerable.SequenceEqual(ListNode.GetValues(expected), ListNode.GetValues(ans)));
        }
    }
}