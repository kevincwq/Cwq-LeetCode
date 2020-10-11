using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/all-possible-full-binary-trees/
    /// 
    /// A full binary tree is a binary tree where each node has exactly 0 or 2 children.
    /// Return a list of all possible full binary trees with N nodes.  Each element of the answer is the root node of one possible tree.
    /// Each node of each tree in the answer must have node.val = 0.
    /// You may return the final list of trees in any order.
    /// 
    /// Example 1:
    /// Input: 7
    /// Output: [[0,0,0,null,null,0,0,null,null,0,0],[0,0,0,null,null,0,0,0,0],[0,0,0,0,0,0,0],[0,0,0,0,0,null,null,null,null,0,0],[0,0,0,0,0,null,null,0,0]]
    /// Explanation:
    /// [<https://s3-lc-upload.s3.amazonaws.com/uploads/2018/08/22/fivetrees.png>]
    /// 
    /// Note:
    /// * 1 <= N <= 20
    /// 
    /// </summary>
    public class N0894_AllPossibleFullBinaryTrees
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
            public IList<TreeNode> AllPossibleFBT(int N) {
                throw new NotImplementedException();
            }
        }
    }
}