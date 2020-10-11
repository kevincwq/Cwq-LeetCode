using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/binary-tree-tilt/
    /// 
    /// Given a binary tree, return the tilt of the whole tree.
    /// The tilt of a tree node is defined as the absolute difference between the sum of all left subtree node values and the sum of all right subtree node values. Null node has tilt 0.
    /// The tilt of the whole tree is defined as the sum of all nodes' tilt.
    /// Example:
    /// Input: 1 / \ 2 3
    /// Output: 1
    /// Explanation: Tilt of node 2 : 0 Tilt of node 3 : 0 Tilt of node 1 : |2-3| = 1 Tilt of binary tree : 0 + 0 + 1 = 1
    /// 
    /// Note:
    /// 
    /// 1. The sum of node values in any subtree won't exceed the range of 32-bit integer.
    /// 2. All the tilt values won't exceed the range of 32-bit integer.
    /// 
    /// </summary>
    public class N0563_BinaryTreeTilt
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
            public int FindTilt(TreeNode root) {
                throw new NotImplementedException();
            }
        }
    }
}