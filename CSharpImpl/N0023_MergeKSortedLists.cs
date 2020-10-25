using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/merge-k-sorted-lists/
    /// 
    /// You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
    /// Merge all the linked-lists into one sorted linked-list and return it.
    /// 
    /// Example 1:
    /// Input: lists = [[1,4,5],[1,3,4],[2,6]]
    /// Output: [1,1,2,3,4,4,5,6]
    /// Explanation: The linked-lists are:
    /// [ 1->4->5, 1->3->4, 2->6
    /// ]
    /// merging them into one sorted list:
    /// 1->1->2->3->4->4->5->6
    /// 
    /// Example 2:
    /// Input: lists = []
    /// Output: []
    /// 
    /// Example 3:
    /// Input: lists = [[]]
    /// Output: []
    /// 
    /// 
    /// Constraints:
    /// * k == lists.length
    /// * 0 <= k <= 10^4
    /// * 0 <= lists[i].length <= 500
    /// * -10^4 <= lists[i][j] <= 10^4
    /// * lists[i] is sorted in ascending order.
    /// * The sum of lists[i].length won't exceed 10^4.
    /// 
    /// </summary>
    public class N0023_MergeKSortedLists
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
            public ListNode MergeKLists(ListNode[] lists)
            {
                var count = lists.Length;
                while (count > 1)
                {
                    var half = count / 2;
                    for (int i = 0; i < half; i++)
                    {
                        lists[i] = MergeTwoLists(lists[i], lists[i + half]);
                    }
                    if (count % 2 != 0)
                    {
                        lists[half] = lists[count - 1];
                    }
                    count = (count + 1) / 2;
                }
                if (count == 1)
                    return lists[0];
                else
                    return null;
            }

            private ListNode MergeTwoLists(ListNode l1, ListNode l2)
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