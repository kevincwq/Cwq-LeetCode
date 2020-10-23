using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// Definition for singly-linked list.
    /// </summary>
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public static ListNode FromValues(IEnumerable<int> nums)
        {
            var head = new ListNode(0);
            var result = head;
            foreach (var num in nums)
            {
                head.next = new ListNode(num);
                head = head.next;
            }
            return result.next;
        }

        public static IEnumerable<int> GetValues(ListNode listNode)
        {
            while (listNode != null)
            {
                yield return listNode.val;
                listNode = listNode.next;
            }
        }
    }

    /// <summary>
    /// Definition for a binary tree node
    /// </summary>
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    /// <summary>
    /// Definition for a QuadTree node.
    /// </summary>
    public class Node
    {
        public bool val;
        public bool isLeaf;
        public Node topLeft;
        public Node topRight;
        public Node bottomLeft;
        public Node bottomRight;

        public Node()
        {
            val = false;
            isLeaf = false;
            topLeft = null;
            topRight = null;
            bottomLeft = null;
            bottomRight = null;
        }

        public Node(bool _val, bool _isLeaf)
        {
            val = _val;
            isLeaf = _isLeaf;
            topLeft = null;
            topRight = null;
            bottomLeft = null;
            bottomRight = null;
        }

        public Node(bool _val, bool _isLeaf, Node _topLeft, Node _topRight, Node _bottomLeft, Node _bottomRight)
        {
            val = _val;
            isLeaf = _isLeaf;
            topLeft = _topLeft;
            topRight = _topRight;
            bottomLeft = _bottomLeft;
            bottomRight = _bottomRight;
        }
    }

    /// <summary>
    /// Definition for Employee.
    /// </summary>
    public class Employee
    {
        public int id;
        public int importance;
        public IList<int> subordinates;
    }
}
