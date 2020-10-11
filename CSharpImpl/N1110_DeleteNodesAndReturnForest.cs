using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/delete-nodes-and-return-forest/
    /// 
    /// Given the root of a binary tree, each node in the tree has a distinct value.
    /// After deleting all nodes with a value in to_delete, we are left with a forest (a disjoint union of trees).
    /// Return the roots of the trees in the remaining forest.  You may return the result in any order.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2019/07/01/screen-shot-2019-07-01-at-53836-pm.png>]
    /// Input: root = [1,2,3,4,5,6,7], to_delete = [3,5]
    /// Output: [[1,2,null,4],[6],[7]]
    /// 
    /// 
    /// Constraints:
    /// * The number of nodes in the given tree is at most 1000.
    /// * Each node has a distinct value between 1 and 1000.
    /// * to_delete.length <= 1000
    /// * to_delete contains distinct values between 1 and 1000.
    /// 
    /// </summary>
    public class N1110_DeleteNodesAndReturnForest
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
            public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete) {
                throw new NotImplementedException();
            }
        }
    }
}