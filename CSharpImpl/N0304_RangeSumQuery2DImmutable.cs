using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/range-sum-query-2d-immutable/
    /// 
    /// Given a 2D matrix matrix, find the sum of the elements inside the rectangle defined by its upper left corner (row1, col1) and lower right corner (row2, col2).
    /// [Range Sum Query 2D</static/images/courses/range_sum_query_2d.png>]
    /// The above rectangle (with the red border) is defined by (row1, col1) = (2, 1) and (row2, col2) = (4, 3), which contains sum = 8.
    /// 
    /// Example:
    /// Given matrix = [ [3, 0, 1, 4, 2], [5, 6, 3, 2, 1], [1, 2, 0, 1, 5], [4, 1, 0, 1, 7], [1, 0, 3, 0, 5] ] sumRegion(2, 1, 4, 3) -> 8 sumRegion(1, 1, 2, 2) -> 11 sumRegion(1, 2, 2, 4) -> 12
    /// 
    /// Note:
    /// 
    /// 1. You may assume that the matrix does not change.
    /// 2. There are many calls to sumRegion function.
    /// 3. You may assume that row1 ≤ row2 and col1 ≤ col2.
    /// 
    /// </summary>
    public class N0304_RangeSumQuery2DImmutable
    {
        public class NumMatrix {
        
            public NumMatrix(int[][] matrix) {
                throw new NotImplementedException();
            }
            
            public int SumRegion(int row1, int col1, int row2, int col2) {
                throw new NotImplementedException();
            }
        }
        
        /**
         * Your NumMatrix object will be instantiated and called as such:
         * NumMatrix obj = new NumMatrix(matrix);
         * int param_1 = obj.SumRegion(row1,col1,row2,col2);
         */
    }
}