using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/construct-binary-tree-from-preorder-and-postorder-traversal/
    /// 
    /// Return any binary tree that matches the given preorder and postorder traversals.
    /// Values in the traversals pre and post are distinct positive integers.
    /// 
    /// 
    /// Example 1:
    /// Input: pre = [1,2,4,5,3,6,7], post = [4,5,2,6,7,3,1]
    /// Output: [1,2,3,4,5,6,7]
    /// 
    /// 
    /// Note:
    /// * 1 <= pre.length == post.length <= 30
    /// * pre[] and post[] are both permutations of 1, 2, ..., pre.length.
    /// * It is guaranteed an answer exists. If there exists multiple answers, you can return any of them.
    /// 
    /// </summary>
    public class N0889_ConstructBinaryTreeFromPreorderAndPostorderTraversal
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
            public TreeNode ConstructFromPrePost(int[] pre, int[] post) {
                throw new NotImplementedException();
            }
        }
    }
}