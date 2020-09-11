using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// Definition for singly-linked list.
    /// </summary>
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public static ListNode FromValues(IEnumerable<int> nums)
        {
            var head = new ListNode(0);
            var result = head;
            foreach (var num in nums)
            {
                head.next = new ListNode(num);
                head = head.next;
            }
            return result.next;
        }

        public IEnumerable<int> GetValues()
        {
            var listNode = this;
            while (listNode != null)
            {
                yield return listNode.val;
                listNode = listNode.next;
            }
        }
    }
}
