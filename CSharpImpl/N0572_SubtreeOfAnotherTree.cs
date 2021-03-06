using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/subtree-of-another-tree/
    /// 
    /// Given two non-empty binary trees s and t, check whether tree t has exactly the same structure and node values with a subtree of s. A subtree of s is a tree consists of a node in s and all of this node's descendants. The tree s could also be considered as a subtree of itself.
    /// Example 1:
    /// Given tree s:
    /// 3 / \ 4 5 / \ 1 2
    /// Given tree t:
    /// 4 / \ 1 2
    /// Return true, because t has the same structure and node values with a subtree of s.
    /// 
    /// 
    /// Example 2:
    /// Given tree s:
    /// 3 / \ 4 5 / \ 1 2 / 0
    /// Given tree t:
    /// 4 / \ 1 2
    /// Return false.
    /// 
    /// 
    /// 
    /// </summary>
    public class N0572_SubtreeOfAnotherTree
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
            public bool IsSubtree(TreeNode s, TreeNode t) {
                throw new NotImplementedException();
            }
        }
    }
}