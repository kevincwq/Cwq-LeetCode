using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
    /// 
    /// Given head which is a reference node to a singly-linked list. The value of each node in the linked list is either 0 or 1. The linked list holds the binary representation of a number.
    /// Return the decimal value of the number in the linked list.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2019/12/05/graph-1.png>]Input: head = [1,0,1]
    /// Output: 5
    /// Explanation: (101) in base 2 = (5) in base 10
    /// 
    /// Example 2:
    /// Input: head = [0]
    /// Output: 0
    /// 
    /// Example 3:
    /// Input: head = [1]
    /// Output: 1
    /// 
    /// Example 4:
    /// Input: head = [1,0,0,1,0,0,1,1,1,0,0,0,0,0,0]
    /// Output: 18880
    /// 
    /// Example 5:
    /// Input: head = [0,0]
    /// Output: 0
    /// 
    /// 
    /// Constraints:
    /// * The Linked List is not empty.
    /// * Number of nodes will not exceed 30.
    /// * Each node's value is either 0 or 1.
    /// 
    /// </summary>
    public class N1290_ConvertBinaryNumberInALinkedListToInteger
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
            public int GetDecimalValue(ListNode head) {
                throw new NotImplementedException();
            }
        }
    }
}