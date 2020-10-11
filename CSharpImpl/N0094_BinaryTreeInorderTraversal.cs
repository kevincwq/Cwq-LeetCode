using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/binary-tree-inorder-traversal/
    /// 
    /// Given the root of a binary tree, return the inorder traversal of its nodes' values.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2020/09/15/inorder_1.jpg>]Input: root = [1,null,2,3]
    /// Output: [1,3,2]
    /// 
    /// Example 2:
    /// Input: root = []
    /// Output: []
    /// 
    /// Example 3:
    /// Input: root = [1]
    /// Output: [1]
    /// 
    /// Example 4:
    /// [<https://assets.leetcode.com/uploads/2020/09/15/inorder_5.jpg>]Input: root = [1,2]
    /// Output: [2,1]
    /// 
    /// Example 5:
    /// [<https://assets.leetcode.com/uploads/2020/09/15/inorder_4.jpg>]Input: root = [1,null,2]
    /// Output: [1,2]
    /// 
    /// 
    /// Constraints:
    /// * The number of nodes in the tree is in the range [0, 100].
    /// * -100 <= Node.val <= 100
    /// 
    /// Follow up:
    /// Recursive solution is trivial, could you do it iteratively?
    /// 
    /// 
    /// </summary>
    public class N0094_BinaryTreeInorderTraversal
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
            public IList<int> InorderTraversal(TreeNode root) {
                throw new NotImplementedException();
            }
        }
    }
}