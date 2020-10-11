using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/minimum-distance-between-bst-nodes/
    /// 
    /// Given a Binary Search Tree (BST) with the root node root, return the minimum difference between the values of any two different nodes in the tree.
    /// Example :
    /// Input: root = [4,2,6,1,3,null,null]
    /// Output: 1
    /// Explanation:
    /// Note that root is a TreeNode object, not an array. The given tree [4,2,6,1,3,null,null] is represented by the following diagram: 4 / \ 2 6 / \ 1 3 while the minimum difference in this tree is 1, it occurs between node 1 and node 2, also between node 3 and node 2.
    /// 
    /// Note:
    /// 1. The size of the BST will be between 2 and 100.
    /// 2. The BST is always valid, each node's value is an integer, and each node's value is different.
    /// 3. This question is the same as 530: https://leetcode.com/problems/minimum-absolute-difference-in-bst/
    /// 
    /// </summary>
    public class N0783_MinimumDistanceBetweenBstNodes
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
            public int MinDiffInBST(TreeNode root) {
                throw new NotImplementedException();
            }
        }
    }
}