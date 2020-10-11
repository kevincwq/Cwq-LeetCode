using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/insufficient-nodes-in-root-to-leaf-paths/
    /// 
    /// Given the root of a binary tree, consider all root to leaf paths: paths from the root to any leaf.  (A leaf is a node with no children.)
    /// A node is insufficient if every such root to leaf path intersecting this node has sum strictly less than limit.
    /// Delete all insufficient nodes simultaneously, and return the root of the resulting binary tree.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2019/06/05/insufficient-11.png>]Input: root = [1,2,3,4,-99,-99,7,8,9,-99,-99,12,13,-99,14], limit = 1
    /// [<https://assets.leetcode.com/uploads/2019/06/05/insufficient-2.png>]Output: [1,2,3,4,null,null,7,8,9,null,14]
    /// 
    /// Example 2:
    /// [<https://assets.leetcode.com/uploads/2019/06/05/insufficient-3.png>]Input: root = [5,4,8,11,null,17,4,7,1,null,null,5,3], limit = 22
    /// [<https://assets.leetcode.com/uploads/2019/06/05/insufficient-4.png>]Output: [5,4,8,11,null,17,4,7,null,null,null,5]
    /// 
    /// 
    /// Example 3:
    /// [<https://assets.leetcode.com/uploads/2019/06/11/screen-shot-2019-06-11-at-83301-pm.png>]Input: root = [1,2,-3,-5,null,4,null], limit = -1
    /// [<https://assets.leetcode.com/uploads/2019/06/11/screen-shot-2019-06-11-at-83517-pm.png>]Output: [1,null,-3,4]
    /// 
    /// 
    /// Note:
    /// 1. The given tree will have between 1 and 5000 nodes.
    /// 2. -10^5 <= node.val <= 10^5
    /// 3. -10^9 <= limit <= 10^9
    /// 
    /// 
    /// 
    /// </summary>
    public class N1080_InsufficientNodesInRootToLeafPaths
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
            public TreeNode SufficientSubset(TreeNode root, int limit) {
                throw new NotImplementedException();
            }
        }
    }
}