using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/find-largest-value-in-each-tree-row/
    /// 
    /// Given the root of a binary tree, return an array of the largest value in each row of the tree (0-indexed).
    /// 
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2020/08/21/largest_e1.jpg>]Input: root = [1,3,2,5,3,null,9]
    /// Output: [1,3,9]
    /// 
    /// Example 2:
    /// Input: root = [1,2,3]
    /// Output: [1,3]
    /// 
    /// Example 3:
    /// Input: root = [1]
    /// Output: [1]
    /// 
    /// Example 4:
    /// Input: root = [1,null,2]
    /// Output: [1,2]
    /// 
    /// Example 5:
    /// Input: root = []
    /// Output: []
    /// 
    /// 
    /// Constraints:
    /// * The number of nodes in the tree will be in the range [0, 10^4].
    /// * -2^31 <= Node.val <= 2^31 - 1
    /// 
    /// </summary>
    public class N0515_FindLargestValueInEachTreeRow
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
            public IList<int> LargestValues(TreeNode root) {
                throw new NotImplementedException();
            }
        }
    }
}