using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/maximum-binary-tree/
    /// 
    /// Given an integer array with no duplicates. A maximum tree building on this array is defined as follow:
    /// 
    /// 1. The root is the maximum number in the array.
    /// 2. The left subtree is the maximum tree constructed from left part subarray divided by the maximum number.
    /// 3. The right subtree is the maximum tree constructed from right part subarray divided by the maximum number.
    /// Construct the maximum tree by the given array and output the root node of this tree.
    /// 
    /// Example 1:
    /// Input: [3,2,1,6,0,5]
    /// Output: return the tree root node representing the following tree: 6 / \ 3 5 \ / 2 0 \ 1
    /// 
    /// Note:
    /// 
    /// 1. The size of the given array will be in the range [1,1000].
    /// 
    /// </summary>
    public class N0654_MaximumBinaryTree
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
            public TreeNode ConstructMaximumBinaryTree(int[] nums) {
                throw new NotImplementedException();
            }
        }
    }
}