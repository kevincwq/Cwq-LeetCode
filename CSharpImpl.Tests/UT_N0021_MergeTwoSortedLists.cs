using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0021_MergeTwoSortedLists
    {
        static object[] TestCases =
        {
            new object[]{ ListNode.FromValues(new[] { 1, 2, 4 }), ListNode.FromValues(new[] { 1, 3, 4 } ),  ListNode.FromValues(new[] { 1, 1, 2, 3, 4, 4 } )},
            new object[]{ ListNode.FromValues(new int[] { }), ListNode.FromValues(new int[] { }), ListNode.FromValues(new int[] { })},
            new object[]{ ListNode.FromValues(new int[] { }), ListNode.FromValues(new[] { 0 } ), ListNode.FromValues(new[] { 0 } )}
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(ListNode l1, ListNode l2, ListNode expected)
        {
            var so = new N0021_MergeTwoSortedLists.Solution1();
            var ans = so.MergeTwoLists(l1, l2);
            Assert.IsTrue(Enumerable.SequenceEqual(ListNode.GetValues(expected), ListNode.GetValues(ans)));
        }
    }
}