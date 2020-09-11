using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using static CSharpImpl.N0002_AddTwoNumbers;

namespace CSharpImpl.Tests
{
    public class UT_N0002_AddTwoNumbers
    {
        static ListNode CreateListNode(IEnumerable<int> nums)
        {
            var head = new ListNode(0);
            var result = head;
            foreach (var num in nums)
            {
                head.next = new ListNode(num);
                head = head.next;
            }
            return head.next;
        }

        static IEnumerable<int> GetListNodeValue(ListNode listNode)
        {
            while (listNode != null)
            {
                yield return listNode.val;
                listNode = listNode.next;
            }
        }

        static object[] TestCases =
        {
            new object[]{ CreateListNode(new int[] { 2, 4, 3 }), CreateListNode(new int[] { 5, 6, 4 }), CreateListNode(new int[] { 7, 0, 8 })},
            new object[]{ CreateListNode(new int[] { 1 }), CreateListNode(new int[] { 9, 9, 9}), CreateListNode(new int[] { 0, 0, 0, 1 })},
            new object[]{ CreateListNode(new int[] { }), CreateListNode(new int[] { 9, 9, 9}), CreateListNode(new int[] { 9, 9, 9 })},
            new object[]{ CreateListNode(new int[] { 0 }), CreateListNode(new int[] { 9, 9, 9}), CreateListNode(new int[] { 9, 9, 9 })},
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(ListNode l1, ListNode l2, ListNode ans)
        {
            var so = new N0002_AddTwoNumbers.Solution1();
            var set = so.AddTwoNumbers(l1, l2);
            Assert.IsTrue(Enumerable.SequenceEqual(GetListNodeValue(ans), GetListNodeValue(set)));
        }


        [TestCaseSource(nameof(TestCases))]
        public void Solution2(ListNode l1, ListNode l2, ListNode ans)
        {
            var so = new N0002_AddTwoNumbers.Solution2();
            var set = so.AddTwoNumbers(l1, l2);
            Assert.IsTrue(Enumerable.SequenceEqual(GetListNodeValue(ans), GetListNodeValue(set)));
        }
    }
}