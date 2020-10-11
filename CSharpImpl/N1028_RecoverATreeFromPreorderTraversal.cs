using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/recover-a-tree-from-preorder-traversal/
    /// 
    /// We run a preorder depth first search on the root of a binary tree.
    /// At each node in this traversal, we output D dashes (where D is the depth of this node), then we output the value of this node.  (If the depth of a node is D, the depth of its immediate child is D+1.  The depth of the root node is 0.)
    /// If a node has only one child, that child is guaranteed to be the left child.
    /// Given the output S of this traversal, recover the tree and return its root.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2019/04/08/recover-a-tree-from-preorder-traversal.png>]
    /// Input: "1-2--3--4-5--6--7"
    /// Output: [1,2,5,3,4,6,7]
    /// 
    /// Example 2:
    /// [<https://assets.leetcode.com/uploads/2019/04/11/screen-shot-2019-04-10-at-114101-pm.png>]
    /// Input: "1-2--3---4-5--6---7"
    /// Output: [1,2,5,3,null,6,null,4,null,7]
    /// 
    /// 
    /// 
    /// 
    /// Example 3:
    /// [<https://assets.leetcode.com/uploads/2019/04/11/screen-shot-2019-04-10-at-114955-pm.png>]
    /// Input: "1-401--349---90--88"
    /// Output: [1,401,null,349,88,90]
    /// 
    /// 
    /// Note:
    /// * The number of nodes in the original tree is between 1 and 1000.
    /// * Each node will have a value between 1 and 10^9.
    /// 
    /// </summary>
    public class N1028_RecoverATreeFromPreorderTraversal
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
            public TreeNode RecoverFromPreorder(string S) {
                throw new NotImplementedException();
            }
        }
    }
}