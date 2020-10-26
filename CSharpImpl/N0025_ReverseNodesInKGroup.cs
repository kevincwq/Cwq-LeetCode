using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/reverse-nodes-in-k-group/
    /// 
    /// Given a linked list, reverse the nodes of a linked list k at a time and return its modified list.
    /// k is a positive integer and is less than or equal to the length of the linked list. If the number of nodes is not a multiple of k then left-out nodes, in the end, should remain as it is.
    /// Follow up:
    /// * Could you solve the problem in O(1) extra memory space?
    /// * You may not alter the values in the list's nodes, only nodes itself may be changed.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2020/10/03/reverse_ex1.jpg>]Input: head = [1,2,3,4,5], k = 2
    /// Output: [2,1,4,3,5]
    /// 
    /// Example 2:
    /// [<https://assets.leetcode.com/uploads/2020/10/03/reverse_ex2.jpg>]Input: head = [1,2,3,4,5], k = 3
    /// Output: [3,2,1,4,5]
    /// 
    /// Example 3:
    /// Input: head = [1,2,3,4,5], k = 1
    /// Output: [1,2,3,4,5]
    /// 
    /// Example 4:
    /// Input: head = [1], k = 1
    /// Output: [1]
    /// 
    /// 
    /// Constraints:
    /// * The number of nodes in the list is in the range sz.
    /// * 1 <= sz <= 5000
    /// * 0 <= Node.val <= 1000
    /// * 1 <= k <= sz
    /// 
    /// </summary>
    public class N0025_ReverseNodesInKGroup
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
            public ListNode ReverseKGroup(ListNode head, int k)
            {
                if (k == 1 || head == null || head.next == null)
                {
                    return head;
                }
                else
                {
                    ListNode dummy = new ListNode(0) { next = head };
                    ListNode pre = dummy;
                    while (pre != null && pre.next != null)
                    {
                        ListNode begin = pre.next;
                        ListNode end = begin;

                        // find the end node
                        int count = 0;
                        while (count != k - 1 && end != null && end.next != null)
                        {
                            end = end.next;
                            count++;
                        }
                        if (count != k - 1)
                            break;

                        // reverse
                        while (count > 0)
                        {
                            var temp = begin.next;
                            begin.next = temp.next;
                            temp.next = pre.next;
                            pre.next = temp;
                            count--;
                        }

                        pre = begin;
                    }
                    return dummy.next;
                }
            }
        }
    }
}