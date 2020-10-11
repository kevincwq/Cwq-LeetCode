using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/find-elements-in-a-contaminated-binary-tree/
    /// 
    /// Given a binary tree with the following rules:
    /// 1. root.val == 0
    /// 2. If treeNode.val == x and treeNode.left != null, then treeNode.left.val == 2 * x + 1
    /// 3. If treeNode.val == x and treeNode.right != null, then treeNode.right.val == 2 * x + 2
    /// Now the binary tree is contaminated, which means all treeNode.val have been changed to -1.
    /// You need to first recover the binary tree and then implement the FindElements class:
    /// * FindElements(TreeNode* root) Initializes the object with a contamined binary tree, you need to recover it first.
    /// * bool find(int target) Return if the target value exists in the recovered binary tree.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2019/11/06/untitled-diagram-4-1.jpg>]
    /// Input
    /// ["FindElements","find","find"]
    /// [[[-1,null,-1]],[1],[2]]
    /// Output
    /// [null,false,true]
    /// Explanation
    /// FindElements findElements = new FindElements([-1,null,-1]); findElements.find(1); // return False findElements.find(2); // return True
    /// Example 2:
    /// [<https://assets.leetcode.com/uploads/2019/11/06/untitled-diagram-4.jpg>]
    /// Input
    /// ["FindElements","find","find","find"]
    /// [[[-1,-1,-1,-1,-1]],[1],[3],[5]]
    /// Output
    /// [null,true,true,false]
    /// Explanation
    /// FindElements findElements = new FindElements([-1,-1,-1,-1,-1]);
    /// findElements.find(1); // return True
    /// findElements.find(3); // return True
    /// findElements.find(5); // return False
    /// 
    /// Example 3:
    /// [<https://assets.leetcode.com/uploads/2019/11/07/untitled-diagram-4-1-1.jpg>]
    /// Input
    /// ["FindElements","find","find","find","find"]
    /// [[[-1,null,-1,-1,null,-1]],[2],[3],[4],[5]]
    /// Output
    /// [null,true,false,false,true]
    /// Explanation
    /// FindElements findElements = new FindElements([-1,null,-1,-1,null,-1]);
    /// findElements.find(2); // return True
    /// findElements.find(3); // return False
    /// findElements.find(4); // return False
    /// findElements.find(5); // return True
    /// 
    /// 
    /// Constraints:
    /// * TreeNode.val == -1
    /// * The height of the binary tree is less than or equal to 20
    /// * The total number of nodes is between [1, 10^4]
    /// * Total calls of find() is between [1, 10^4]
    /// * 0 <= target <= 10^6
    /// 
    /// </summary>
    public class N1261_FindElementsInAContaminatedBinaryTree
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
        public class FindElements {
        
            public FindElements(TreeNode root) {
                throw new NotImplementedException();
            }
            
            public bool Find(int target) {
                throw new NotImplementedException();
            }
        }
        
        /**
         * Your FindElements object will be instantiated and called as such:
         * FindElements obj = new FindElements(root);
         * bool param_1 = obj.Find(target);
         */
    }
}