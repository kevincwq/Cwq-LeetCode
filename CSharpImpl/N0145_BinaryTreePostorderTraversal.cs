using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/binary-tree-postorder-traversal/
    /// 
    /// Given the root of a binary tree, return the postorder traversal of its nodes' values.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2020/08/28/pre1.jpg>]Input: root = [1,null,2,3]
    /// Output: [3,2,1]
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
    /// [<https://assets.leetcode.com/uploads/2020/08/28/pre3.jpg>]Input: root = [1,2]
    /// Output: [2,1]
    /// 
    /// Example 5:
    /// [<https://assets.leetcode.com/uploads/2020/08/28/pre2.jpg>]Input: root = [1,null,2]
    /// Output: [2,1]
    /// 
    /// 
    /// Constraints:
    /// * The number of the nodes in the tree is in the range [0, 100].
    /// * -100 <= Node.val <= 100
    /// 
    /// Follow up:
    /// Recursive solution is trivial, could you do it iteratively?
    /// 
    /// 
    /// </summary>
    public class N0145_BinaryTreePostorderTraversal
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
            public IList<int> PostorderTraversal(TreeNode root) {
                throw new NotImplementedException();
            }
        }
    }
}