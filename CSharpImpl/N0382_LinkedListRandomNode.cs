using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/linked-list-random-node/
    /// 
    /// Given a singly linked list, return a random node's value from the linked list. Each node must have the same probability of being chosen.
    /// Follow up:
    /// What if the linked list is extremely large and its length is unknown to you? Could you solve this efficiently without using extra space?
    /// 
    /// Example:
    /// 
    /// // Init a singly linked list [1,2,3]. ListNode head = new ListNode(1); head.next = new ListNode(2); head.next.next = new ListNode(3); Solution solution = new Solution(head); // getRandom() should return either 1, 2, or 3 randomly. Each element should have equal probability of returning. solution.getRandom();
    /// 
    /// </summary>
    public class N0382_LinkedListRandomNode
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
        
            /** @param head The linked list's head.
                Note that the head is guaranteed to be not null, so it contains at least one node. */
            public Solution1(ListNode head) {
                throw new NotImplementedException();
            }
            
            /** Returns a random node's value. */
            public int GetRandom() {
                throw new NotImplementedException();
            }
        }
        
        /**
         * Your Solution1 object will be instantiated and called as such:
         * Solution1 obj = new Solution1(head);
         * int param_1 = obj.GetRandom();
         */
    }
}