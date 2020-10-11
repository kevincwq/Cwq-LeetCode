using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/add-two-numbers/
    /// 
    /// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
    /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2020/10/02/addtwonumber1.jpg>]Input: l1 = [2,4,3], l2 = [5,6,4]
    /// Output: [7,0,8]
    /// Explanation: 342 + 465 = 807.
    /// 
    /// Example 2:
    /// Input: l1 = [0], l2 = [0]
    /// Output: [0]
    /// 
    /// Example 3:
    /// Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
    /// Output: [8,9,9,9,0,0,0,1]
    /// 
    /// 
    /// Constraints:
    /// * The number of nodes in each linked list is in the range [1, 100].
    /// * 0 <= Node.val <= 9
    /// * It is guaranteed that the list represents a number that does not have leading zeros.
    /// 
    /// </summary>
    public class N0002_AddTwoNumbers
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
        /// <summary>
        /// Reuse some nodes of inputs
        /// </summary>
        public class Solution1
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                var result = new ListNode(0);
                var temp = result;
                int carry = 0;
                while (l1 != null && l2 != null)
                {
                    var sum = l1.val + l2.val + carry;
                    temp.next = new ListNode(sum % 10);
                    carry = sum / 10;
                    temp = temp.next;
                    l1 = l1.next;
                    l2 = l2.next;
                }
                temp.next = l1 ?? l2;
                while (carry > 0 && temp.next != null)
                {
                    var sum = temp.next.val + carry;
                    carry = sum / 10;
                    temp.next.val = sum % 10;
                    temp = temp.next;
                }
                if (carry > 0)
                {
                    temp.next = new ListNode(carry);
                }
                return result.next;
            }
        }

        /// <summary>
        /// Reuse some nodes of inputs
        /// </summary>
        public class Solution2
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                var result = new ListNode(0);
                var temp = result;
                var op1 = l1;
                var op2 = l2;
                int carry = 0;
                while (op1 != null || op2 != null)
                {
                    var sum = (op1 == null ? 0 : op1.val) + (op2 == null ? 0 : op2.val) + carry;
                    temp.next = new ListNode(sum % 10);
                    carry = sum / 10;
                    temp = temp.next;
                    op1 = op1?.next;
                    op2 = op2?.next;
                }
                if (carry > 0)
                {
                    temp.next = new ListNode(carry);
                }
                return result.next;
            }
        }
    }
}