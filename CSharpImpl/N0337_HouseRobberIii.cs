using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/house-robber-iii/
    /// 
    /// The thief has found himself a new place for his thievery again. There is only one entrance to this area, called the "root." Besides the root, each house has one and only one parent house. After a tour, the smart thief realized that "all houses in this place forms a binary tree". It will automatically contact the police if two directly-linked houses were broken into on the same night.
    /// Determine the maximum amount of money the thief can rob tonight without alerting the police.
    /// Example 1:
    /// Input: [3,2,3,null,3,null,1] 3 / \ 2 3 \ \ 3 1
    /// Output: 7
    /// Explanation: Maximum amount of money the thief can rob = 3 + 3 + 1 = 7.
    /// 
    /// Example 2:
    /// Input: [3,4,5,1,3,null,1]   3 / \ 4 5 / \ \ 1 3 1
    /// Output: 9
    /// Explanation: Maximum amount of money the thief can rob = 4 + 5 = 9.
    /// 
    /// </summary>
    public class N0337_HouseRobberIii
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
            public int Rob(TreeNode root) {
                throw new NotImplementedException();
            }
        }
    }
}