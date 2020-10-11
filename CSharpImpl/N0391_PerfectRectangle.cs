using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/perfect-rectangle/
    /// 
    /// Given N axis-aligned rectangles where N > 0, determine if they all together form an exact cover of a rectangular region.
    /// Each rectangle is represented as a bottom-left point and a top-right point. For example, a unit square is represented as [1,1,2,2]. (coordinate of bottom-left point is (1, 1) and top-right point is (2, 2)).
    /// <https://assets.leetcode.com/uploads/2018/10/22/rectangle_perfect.gif>
    /// Example 1:
    /// rectangles = [ [1,1,3,3], [3,1,4,2], [3,2,4,4], [1,3,2,4], [2,3,3,4] ] Return true. All 5 rectangles together form an exact cover of a rectangular region.
    /// 
    /// 
    /// 
    /// <https://assets.leetcode.com/uploads/2018/10/22/rectangle_separated.gif>
    /// Example 2:
    /// rectangles = [ [1,1,2,3], [1,3,2,4], [3,1,4,2], [3,2,4,4] ] Return false. Because there is a gap between the two rectangular regions.
    /// 
    /// 
    /// 
    /// <https://assets.leetcode.com/uploads/2018/10/22/rectangle_hole.gif>
    /// Example 3:
    /// rectangles = [ [1,1,3,3], [3,1,4,2], [1,3,2,4], [3,2,4,4] ] Return false. Because there is a gap in the top center.
    /// 
    /// 
    /// 
    /// <https://assets.leetcode.com/uploads/2018/10/22/rectangle_intersect.gif>
    /// Example 4:
    /// rectangles = [ [1,1,3,3], [3,1,4,2], [1,3,2,4], [2,2,4,4] ] Return false. Because two of the rectangles overlap with each other.
    /// 
    /// 
    /// 
    /// </summary>
    public class N0391_PerfectRectangle
    {
        public class Solution1 {
            public bool IsRectangleCover(int[][] rectangles) {
                throw new NotImplementedException();
            }
        }
    }
}