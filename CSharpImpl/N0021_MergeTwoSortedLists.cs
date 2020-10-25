using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/merge-two-sorted-lists/
    /// 
    /// Merge two sorted linked lists and return it as a new sorted list. The new list should be made by splicing together the nodes of the first two lists.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2020/10/03/merge_ex1.jpg>]Input: l1 = [1,2,4], l2 = [1,3,4]
    /// Output: [1,1,2,3,4,4]
    /// 
    /// Example 2:
    /// Input: l1 = [], l2 = []
    /// Output: []
    /// 
    /// Example 3:
    /// Input: l1 = [], l2 = [0]
    /// Output: [0]
    /// 
    /// 
    /// Constraints:
    /// * The number of nodes in both lists is in the range [0, 50].
    /// * -100 <= Node.val <= 100
    /// * Both l1 and l2 are sorted in non-decreasing order.
    /// 
    /// </summary>
    public class N0021_MergeTwoSortedLists
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
            public ListNode MergeTwoLists(ListNode l1, ListNode l2)
            {
                var dummy = new ListNode(0);
                var move = dummy;
                while (l1 != null && l2 != null)
                {
                    if (l1.val < l2.val)
                    {
                        move.next = l1;
                        l1 = l1.next;
                    }
                    else
                    {
                        move.next = l2;
                        l2 = l2.next;
                    }
                    move = move.next;
                }
                move.next = l1 ?? l2;
                return dummy.next;
            }
        }
    }
}