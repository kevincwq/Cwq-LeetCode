using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/recover-binary-search-tree/
    /// 
    /// Two elements of a binary search tree (BST) are swapped by mistake.
    /// Recover the tree without changing its structure.
    /// Example 1:
    /// Input: [1,3,null,null,2]   1   /  3   \   2
    /// Output: [3,1,null,null,2]   3   /  1   \   2
    /// 
    /// Example 2:
    /// Input: [3,1,4,null,null,2] 3 / \ 1 4   /   2
    /// Output: [2,1,4,null,null,3] 2 / \ 1 4   /  3
    /// 
    /// Follow up:
    /// * A solution using O(n) space is pretty straight forward.
    /// * Could you devise a constant space solution?
    /// 
    /// </summary>
    public class N0099_RecoverBinarySearchTree
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
            public void RecoverTree(TreeNode root) {
                throw new NotImplementedException();
            }
        }
    }
}