using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/maximum-level-sum-of-a-binary-tree/
    /// 
    /// Given the root of a binary tree, the level of its root is 1, the level of its children is 2, and so on.
    /// Return the smallest level X such that the sum of all the values of nodes at level X is maximal.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2019/05/03/capture.JPG>]Input: root = [1,7,0,7,-8,null,null]
    /// Output: 2
    /// Explanation: Level 1 sum = 1.
    /// Level 2 sum = 7 + 0 = 7.
    /// Level 3 sum = 7 + -8 = -1.
    /// So we return the level with the maximum sum which is level 2.
    /// 
    /// Example 2:
    /// Input: root = [989,null,10250,98693,-89388,null,null,null,-32127]
    /// Output: 2
    /// 
    /// 
    /// Constraints:
    /// * The number of nodes in the tree is in the range [1, 10^4].
    /// * -10^5 <= Node.val <= 10^5
    /// 
    /// </summary>
    public class N1161_MaximumLevelSumOfABinaryTree
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
            public int MaxLevelSum(TreeNode root) {
                throw new NotImplementedException();
            }
        }
    }
}