using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/range-sum-of-bst/
    /// 
    /// Given the root node of a binary search tree, return the sum of values of all nodes with value between L and R (inclusive).
    /// The binary search tree is guaranteed to have unique values.
    /// 
    /// 
    /// Example 1:
    /// Input: root = [10,5,15,3,7,null,18], L = 7, R = 15
    /// Output: 32
    /// 
    /// Example 2:
    /// Input: root = [10,5,15,3,7,13,18,1,null,6], L = 6, R = 10
    /// Output: 23
    /// 
    /// 
    /// Note:
    /// 1. The number of nodes in the tree is at most 10000.
    /// 2. The final answer is guaranteed to be less than 2^31.
    /// 
    /// 
    /// </summary>
    public class N0938_RangeSumOfBst
    {
        /**
         * Definition for a binary tree node.
         * public class TreeNode {
         *     public int val;
         *     public TreeNode left;
         *     public TreeNode right;
         *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         *         this.val = val;
         *         this.left = left;
         *         this.right = right;
         *     }
         * }
         */
        public class Solution1 {
            public int RangeSumBST(TreeNode root, int L, int R) {
                throw new NotImplementedException();
            }
        }
    }
}