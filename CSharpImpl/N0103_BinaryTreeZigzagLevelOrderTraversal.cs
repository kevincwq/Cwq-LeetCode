using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
    /// 
    /// Given a binary tree, return the zigzag level order traversal of its nodes' values. (ie, from left to right, then right to left for the next level and alternate between).
    /// For example:
    /// Given binary tree [3,9,20,null,null,15,7],
    /// 3 / \ 9 20 / \ 15 7
    /// 
    /// return its zigzag level order traversal as:
    /// [ [3], [20,9], [15,7] ]
    /// 
    /// </summary>
    public class N0103_BinaryTreeZigzagLevelOrderTraversal
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
            public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
                throw new NotImplementedException();
            }
        }
    }
}