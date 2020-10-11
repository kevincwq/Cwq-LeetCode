using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/balance-a-binary-search-tree/
    /// 
    /// Given a binary search tree, return a balanced binary search tree with the same node values.
    /// A binary search tree is balanced if and only if the depth of the two subtrees of every node never differ by more than 1.
    /// If there is more than one answer, return any of them.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2019/08/22/1515_ex1.png>][<https://assets.leetcode.com/uploads/2019/08/22/1515_ex1_out.png>]
    /// Input: root = [1,null,2,null,3,null,4,null,null]
    /// Output: [2,1,3,null,null,null,4]
    /// Explanation: This is not the only correct answer, [3,1,4,null,2,null,null] is also correct.
    /// 
    /// 
    /// Constraints:
    /// * The number of nodes in the tree is between 1 and 10^4.
    /// * The tree nodes will have distinct values between 1 and 10^5.
    /// 
    /// </summary>
    public class N1382_BalanceABinarySearchTree
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
            public TreeNode BalanceBST(TreeNode root) {
                throw new NotImplementedException();
            }
        }
    }
}