using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/binary-tree-right-side-view/
    /// 
    /// Given a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.
    /// Example:
    /// Input: [1,2,3,null,5,null,4]
    /// Output: [1, 3, 4]
    /// Explanation:
    /// 1 <--- / \ 2 3 <--- \ \ 5 4 <---
    /// 
    /// </summary>
    public class N0199_BinaryTreeRightSideView
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
            public IList<int> RightSideView(TreeNode root) {
                throw new NotImplementedException();
            }
        }
    }
}