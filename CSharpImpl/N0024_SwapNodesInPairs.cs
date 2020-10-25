using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/swap-nodes-in-pairs/
    /// 
    /// Given a linked list, swap every two adjacent nodes and return its head.
    /// You may not modify the values in the list's nodes. Only nodes itself may be changed.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2020/10/03/swap_ex1.jpg>]Input: head = [1,2,3,4]
    /// Output: [2,1,4,3]
    /// 
    /// Example 2:
    /// Input: head = []
    /// Output: []
    /// 
    /// Example 3:
    /// Input: head = [1]
    /// Output: [1]
    /// 
    /// 
    /// Constraints:
    /// * The number of nodes in the list is in the range [0, 100].
    /// * 0 <= Node.val <= 100
    /// 
    /// </summary>
    public class N0024_SwapNodesInPairs
    {
        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int val=0, ListNode next=null) {
         *         this.val = val;
         *         this.next = next;
         *     }
         * }
         */
        public class Solution1
        {
            public ListNode SwapPairs(ListNode head)
            {
                var dummy = new ListNode(0) { next = head };
                var it = dummy;
                while (it.next != null && it.next.next != null)
                {
                    var temp = it.next;
                    it.next = temp.next;
                    temp.next = temp.next.next;
                    it.next.next = temp;
                    it = temp;
                }
                return dummy.next;
            }
        }
    }
}