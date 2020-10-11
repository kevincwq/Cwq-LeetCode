using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/all-paths-from-source-to-target/
    /// 
    /// Given a directed acyclic graph of N nodes. Find all possible paths from node 0 to node N-1, and return them in any order.
    /// The graph is given as follows:  the nodes are 0, 1, ..., graph.length - 1.  graph[i] is a list of all nodes j for which the edge (i, j) exists.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2020/09/28/all_1.jpg>]Input: graph = [[1,2],[3],[3],[]]
    /// Output: [[0,1,3],[0,2,3]]
    /// Explanation: There are two paths: 0 -> 1 -> 3 and 0 -> 2 -> 3.
    /// 
    /// Example 2:
    /// [<https://assets.leetcode.com/uploads/2020/09/28/all_2.jpg>]Input: graph = [[4,3,1],[3,2,4],[3],[4],[]]
    /// Output: [[0,4],[0,3,4],[0,1,3,4],[0,1,2,3,4],[0,1,4]]
    /// 
    /// Example 3:
    /// Input: graph = [[1],[]]
    /// Output: [[0,1]]
    /// 
    /// Example 4:
    /// Input: graph = [[1,2,3],[2],[3],[]]
    /// Output: [[0,1,2,3],[0,2,3],[0,3]]
    /// 
    /// Example 5:
    /// Input: graph = [[1,3],[2],[3],[]]
    /// Output: [[0,1,2,3],[0,3]]
    /// 
    /// 
    /// Constraints:
    /// * The number of nodes in the graph will be in the range [2, 15].
    /// * You can print different paths in any order, but you should keep the order of nodes inside one path.
    /// 
    /// </summary>
    public class N0797_AllPathsFromSourceToTarget
    {
        public class Solution1 {
            public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
                throw new NotImplementedException();
            }
        }
    }
}