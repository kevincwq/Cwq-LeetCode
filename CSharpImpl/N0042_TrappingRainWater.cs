using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/trapping-rain-water/
    /// 
    /// Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.
    /// <https://assets.leetcode.com/uploads/2018/10/22/rainwatertrap.png>
    /// The above elevation map is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped. Thanks Marcos for contributing this image!
    /// Example:
    /// Input: [0,1,0,2,1,0,1,3,2,1,2,1]
    /// Output: 6
    /// 
    /// Constraints:
    /// n == height.length
    /// 0 <= n <= 3 * 10^4
    /// 0 <= height[i] <= 10^5
    /// </summary>
    public class N0042_TrappingRainWater
    {
        /// <summary>
        /// Two pointers
        /// </summary>
        public class Solution1
        {
            public int Trap(int[] height)
            {
                int total = 0;
                if (height.Length > 2)
                {
                    int index_l = 1, index_r = height.Length - 2;
                    int level_l = height[0], level_r = height[height.Length - 1];
                    while (index_l <= index_r)
                    {
                        if (level_l <= level_r)
                        {
                            if (height[index_l] < level_l)
                            {
                                total += level_l - height[index_l];
                            }
                            else if (height[index_l] > level_l)
                            {
                                level_l = height[index_l];
                            }
                            index_l++;
                        }
                        else
                        {
                            if (height[index_r] < level_r)
                            {
                                total += level_r - height[index_r];
                            }
                            else if (height[index_r] > level_r)
                            {
                                level_r = height[index_r];
                            }
                            index_r--;
                        }
                    }
                }
                return total;
            }
        }

        /// <summary>
        /// Level by level (obsolete)
        /// </summary>
        public class Solution2
        {
            public int Trap(int[] height)
            {
                int total = 0, level = 0, low = 0, high = height.Length - 1;
                int subTotal;
                do
                {
                    subTotal = 0;
                    while (height[low] <= level)
                        low++;
                    while (height[high] <= level)
                        high--;
                    for (int i = low + 1; i < high; i++)
                    {
                        if (height[i] <= level)
                            subTotal++;
                    }
                    total += subTotal;
                    level++;
                } while (subTotal > 0);
                return total;
            }
        }
    }
}