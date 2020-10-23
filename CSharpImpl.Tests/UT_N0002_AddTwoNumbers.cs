using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0002_AddTwoNumbers
    {
        static object[] TestCases1 =
              {
            new object[]{ ListNode.FromValues(new int[] { }), ListNode.FromValues(new int[] { 9, 9, 9}), ListNode.FromValues(new int[] { 9, 9, 9 })},
            new object[]{ ListNode.FromValues(new int[] { 0 }), ListNode.FromValues(new int[] { 9, 9, 9}), ListNode.FromValues(new int[] { 9, 9, 9 })},
            new object[]{ ListNode.FromValues(new int[] { 2, 4, 3 }), ListNode.FromValues(new int[] { 5, 6, 4 }), ListNode.FromValues(new int[] { 7, 0, 8 })},
            new object[]{ ListNode.FromValues(new int[] { 1 }), ListNode.FromValues(new int[] { 9, 9, 9}), ListNode.FromValues(new int[] { 0, 0, 0, 1 })},
        };

        static object[] TestCases2 =
        {
            new object[]{ ListNode.FromValues(new int[] { }), ListNode.FromValues(new int[] { 9, 9, 9}), ListNode.FromValues(new int[] { 9, 9, 9 })},
            new object[]{ ListNode.FromValues(new int[] { 0 }), ListNode.FromValues(new int[] { 9, 9, 9}), ListNode.FromValues(new int[] { 9, 9, 9 })},
            new object[]{ ListNode.FromValues(new int[] { 2, 4, 3 }), ListNode.FromValues(new int[] { 5, 6, 4 }), ListNode.FromValues(new int[] { 7, 0, 8 })},
            new object[]{ ListNode.FromValues(new int[] { 1 }), ListNode.FromValues(new int[] { 9, 9, 9}), ListNode.FromValues(new int[] { 0, 0, 0, 1 })},
        };

        [TestCaseSource(nameof(TestCases1))]
        public void Solution1(ListNode l1, ListNode l2, ListNode expected)
        {
            var so = new N0002_AddTwoNumbers.Solution1();
            var ans = so.AddTwoNumbers(l1, l2);
            Assert.IsTrue(Enumerable.SequenceEqual(ListNode.GetValues(expected), ListNode.GetValues(ans)));
        }


        [TestCaseSource(nameof(TestCases2))]
        public void Solution2(ListNode l1, ListNode l2, ListNode expected)
        {
            var so = new N0002_AddTwoNumbers.Solution2();
            var ans = so.AddTwoNumbers(l1, l2);
            Assert.IsTrue(Enumerable.SequenceEqual(ListNode.GetValues(expected), ListNode.GetValues(ans)));
        }
    }
}