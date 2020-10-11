using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/binary-search-tree-iterator/
    /// 
    /// Implement an iterator over a binary search tree (BST). Your iterator will be initialized with the root node of a BST.
    /// Calling next() will return the next smallest number in the BST.
    /// 
    /// 
    /// Example:
    /// [<https://assets.leetcode.com/uploads/2018/12/25/bst-tree.png>]
    /// BSTIterator iterator = new BSTIterator(root); iterator.next(); // return 3 iterator.next(); // return 7 iterator.hasNext(); // return true iterator.next(); // return 9 iterator.hasNext(); // return true iterator.next(); // return 15 iterator.hasNext(); // return true iterator.next(); // return 20 iterator.hasNext(); // return false
    /// 
    /// 
    /// Note:
    /// * next() and hasNext() should run in average O(1) time and uses O(h) memory, where h is the height of the tree.
    /// * You may assume that next() call will always be valid, that is, there will be at least a next smallest number in the BST when next() is called.
    /// 
    /// </summary>
    public class N0173_BinarySearchTreeIterator
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
        public class BSTIterator {
        
            public BSTIterator(TreeNode root) {
                throw new NotImplementedException();
            }
            
            /** @return the next smallest number */
            public int Next() {
                throw new NotImplementedException();
            }
            
            /** @return whether we have a next smallest number */
            public bool HasNext() {
                throw new NotImplementedException();
            }
        }
        
        /**
         * Your BSTIterator object will be instantiated and called as such:
         * BSTIterator obj = new BSTIterator(root);
         * int param_1 = obj.Next();
         * bool param_2 = obj.HasNext();
         */
    }
}