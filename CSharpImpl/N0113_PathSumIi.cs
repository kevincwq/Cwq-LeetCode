using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/path-sum-ii/
    /// 
    /// Given a binary tree and a sum, find all root-to-leaf paths where each path's sum equals the given sum.
    /// Note: A leaf is a node with no children.
    /// Example:
    /// Given the below binary tree and sum = 22,
    /// 5 / \ 4 8 / / \ 11 13 4 / \ / \ 7 2 5 1
    /// 
    /// Return:
    /// [ [5,4,11,2], [5,8,4,5] ]
    /// 
    /// </summary>
    public class N0113_PathSumIi
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
            public IList<IList<int>> PathSum(TreeNode root, int sum) {
                throw new NotImplementedException();
            }
        }
    }
}