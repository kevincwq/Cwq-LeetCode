using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
    /// 
    /// Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).
    /// For example:
    /// Given binary tree [3,9,20,null,null,15,7],
    /// 3 / \ 9 20 / \ 15 7
    /// 
    /// return its bottom-up level order traversal as:
    /// [ [15,7], [9,20], [3] ]
    /// 
    /// </summary>
    public class N0107_BinaryTreeLevelOrderTraversalIi
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
            public IList<IList<int>> LevelOrderBottom(TreeNode root) {
                throw new NotImplementedException();
            }
        }
    }
}