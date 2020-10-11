using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/grid-illumination/
    /// 
    /// You are given a grid of size N x N, and each cell of this grid has a lamp that is initially turned off.
    /// You are also given an array of lamp positions lamps, where lamps[i] = [row_i, col_i] indicates that the lamp at grid[row_i][col_i] is turned on. When a lamp is turned on, it illuminates its cell and all other cells in the same row, column, or diagonal.
    /// Finally, you are given a query array queries, where queries[i] = [row_i, col_i]. For the i^th query, determine whether grid[row_i][col_i] is illuminated or not. After answering the i^th query, turn off the lamp at grid[row_i][col_i] and its 8 adjacent lamps if they exist. A lamp is adjacent if its cell shares either a side or corner with grid[row_i][col_i].
    /// Return an array of integers ans, where ans[i] should be 1 if the lamp in the i^th query was illuminated, or 0 if the lamp was not.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2020/08/19/illu_1.jpg>]Input: N = 5, lamps = [[0,0],[4,4]], queries = [[1,1],[1,0]]
    /// Output: [1,0]
    /// Explanation: We have the initial grid with all lamps turned off. In the above picture we see the grid after turning on the lamp at grid[0][0] then turning on the lamp at grid[4][4].
    /// The 0^th query asks if the lamp at grid[1][1] is illuminated or not (the blue square). It is illuminated, so set ans[0] = 1. Then, we turn off all lamps in the red square.
    /// [<https://assets.leetcode.com/uploads/2020/08/19/illu_step1.jpg>]The 1^st query asks if the lamp at grid[1][0] is illuminated or not (the blue square). It is not illuminated, so set ans[1] = 1. Then, we turn off all lamps in the red rectangle.
    /// [<https://assets.leetcode.com/uploads/2020/08/19/illu_step2.jpg>]
    /// Example 2:
    /// Input: N = 5, lamps = [[0,0],[4,4]], queries = [[1,1],[1,1]]
    /// Output: [1,1]
    /// 
    /// Example 3:
    /// Input: N = 5, lamps = [[0,0],[0,4]], queries = [[0,4],[0,1],[1,4]]
    /// Output: [1,1,0]
    /// 
    /// 
    /// Constraints:
    /// * 1 <= N <= 10^9
    /// * 0 <= lamps.length <= 20000
    /// * lamps[i].length == 2
    /// * 0 <= lamps[i][j] < N
    /// * 0 <= queries.length <= 20000
    /// * queries[i].length == 2
    /// * 0 <= queries[i][j] < N
    /// 
    /// </summary>
    public class N1001_GridIllumination
    {
        public class Solution1 {
            public int[] GridIllumination(int N, int[][] lamps, int[][] queries) {
                throw new NotImplementedException();
            }
        }
    }
}