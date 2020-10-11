using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
    /// 
    /// Given preorder and inorder traversal of a tree, construct the binary tree.
    /// Note:
    /// You may assume that duplicates do not exist in the tree.
    /// For example, given
    /// preorder = [3,9,20,15,7] inorder = [9,3,15,20,7]
    /// 
    /// Return the following binary tree:
    /// 3 / \ 9 20 / \ 15 7
    /// 
    /// </summary>
    public class N0105_ConstructBinaryTreeFromPreorderAndInorderTraversal
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
            public TreeNode BuildTree(int[] preorder, int[] inorder) {
                throw new NotImplementedException();
            }
        }
    }
}