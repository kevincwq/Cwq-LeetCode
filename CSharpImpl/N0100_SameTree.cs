using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/same-tree/
    /// 
    /// Given two binary trees, write a function to check if they are the same or not.
    /// Two binary trees are considered the same if they are structurally identical and the nodes have the same value.
    /// Example 1:
    /// Input: 1 1 / \ / \ 2 3 2 3 [1,2,3], [1,2,3]
    /// Output: true
    /// 
    /// Example 2:
    /// Input: 1 1 / \ 2 2 [1,2], [1,null,2]
    /// Output: false
    /// 
    /// Example 3:
    /// Input: 1 1 / \ / \ 2 1 1 2 [1,2,1], [1,1,2]
    /// Output: false
    /// 
    /// </summary>
    public class N0100_SameTree
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
            public bool IsSameTree(TreeNode p, TreeNode q) {
                throw new NotImplementedException();
            }
        }
    }
}