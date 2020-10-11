using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/find-mode-in-binary-search-tree/
    /// 
    /// Given a binary search tree (BST) with duplicates, find all the mode(s)<https://en.wikipedia.org/wiki/Mode_(statistics)> (the most frequently occurred element) in the given BST.
    /// Assume a BST is defined as follows:
    /// * The left subtree of a node contains only nodes with keys less than or equal to the node's key.
    /// * The right subtree of a node contains only nodes with keys greater than or equal to the node's key.
    /// * Both the left and right subtrees must also be binary search trees.
    /// 
    /// For example:
    /// Given BST [1,null,2,2],
    /// 1 \ 2 / 2
    /// 
    /// 
    /// return [2].
    /// Note: If a tree has more than one mode, you can return them in any order.
    /// Follow up: Could you do that without using any extra space? (Assume that the implicit stack space incurred due to recursion does not count).
    /// 
    /// </summary>
    public class N0501_FindModeInBinarySearchTree
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
            public int[] FindMode(TreeNode root) {
                throw new NotImplementedException();
            }
        }
    }
}