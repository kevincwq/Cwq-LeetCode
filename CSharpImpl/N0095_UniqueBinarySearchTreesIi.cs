using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/unique-binary-search-trees-ii/
    /// 
    /// Given an integer n, generate all structurally unique BST's (binary search trees) that store values 1 ... n.
    /// Example:
    /// Input: 3
    /// Output:
    /// [
    /// [1,null,3,2],
    /// [3,2,null,1],
    /// [3,1,null,null,2],
    /// [2,1,3],
    /// [1,null,2,null,3]
    /// ]
    /// Explanation:
    /// The above output corresponds to the 5 unique BST's shown below: 1 3 3 2 1 \ / / / \ \ 3 2 1 1 3 2 / / \ \ 2 1 2 3
    /// 
    /// 
    /// Constraints:
    /// * 0 <= n <= 8
    /// 
    /// </summary>
    public class N0095_UniqueBinarySearchTreesIi
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
            public IList<TreeNode> GenerateTrees(int n) {
                throw new NotImplementedException();
            }
        }
    }
}