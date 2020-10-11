using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/remove-nth-node-from-end-of-list/
    /// 
    /// Given the head of a linked list, remove the n^th node from the end of the list and return its head.
    /// Follow up: Could you do this in one pass?
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2020/10/03/remove_ex1.jpg>]Input: head = [1,2,3,4,5], n = 2
    /// Output: [1,2,3,5]
    /// 
    /// Example 2:
    /// Input: head = [1], n = 1
    /// Output: []
    /// 
    /// Example 3:
    /// Input: head = [1,2], n = 1
    /// Output: [1]
    /// 
    /// 
    /// Constraints:
    /// * The number of nodes in the list is sz.
    /// * 1 <= sz <= 30
    /// * 0 <= Node.val <= 100
    /// * 1 <= n <= sz
    /// 
    /// </summary>
    public class N0019_RemoveNthNodeFromEndOfList
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
        public class Solution1 {
            public ListNode RemoveNthFromEnd(ListNode head, int n) {
                throw new NotImplementedException();
            }
        }
    }
}