using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/univalued-binary-tree/
    /// 
    /// A binary tree is univalued if every node in the tree has the same value.
    /// Return true if and only if the given tree is univalued.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2018/12/28/unival_bst_1.png>]Input: [1,1,1,1,1,null,1]
    /// Output: true
    /// 
    /// Example 2:
    /// [<https://assets.leetcode.com/uploads/2018/12/28/unival_bst_2.png>]Input: [2,2,2,5,2]
    /// Output: false
    /// 
    /// 
    /// Note:
    /// 1. The number of nodes in the given tree will be in the range [1, 100].
    /// 2. Each node's value will be an integer in the range [0, 99].
    /// 
    /// </summary>
    public class N0965_UnivaluedBinaryTree
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
            public bool IsUnivalTree(TreeNode root) {
                throw new NotImplementedException();
            }
        }
    }
}