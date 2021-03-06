using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/increasing-order-search-tree/
    /// 
    /// Given a binary search tree, rearrange the tree in in-order so that the leftmost node in the tree is now the root of the tree, and every node has no left child and only 1 right child.
    /// Example 1:
    /// Input: [5,3,6,2,4,null,8,1,null,null,null,7,9] 5 / \ 3 6 / \ \ 2 4 8
    /// / / \ 1 7 9
    /// Output: [1,null,2,null,3,null,4,null,5,null,6,null,7,null,8,null,9] 1
    /// \
    /// 2
    /// \
    /// 3
    /// \
    /// 4
    /// \
    /// 5
    /// \
    /// 6
    /// \
    /// 7
    /// \
    /// 8
    /// \ 9
    /// 
    /// Constraints:
    /// * The number of nodes in the given tree will be between 1 and 100.
    /// * Each node will have a unique integer value from 0 to 1000.
    /// 
    /// </summary>
    public class N0897_IncreasingOrderSearchTree
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
            public TreeNode IncreasingBST(TreeNode root) {
                throw new NotImplementedException();
            }
        }
    }
}