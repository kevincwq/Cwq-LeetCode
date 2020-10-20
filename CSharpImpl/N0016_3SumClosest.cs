using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/3sum-closest/
    /// 
    /// Given an array nums of n integers and an integer target, find three integers in nums such that the sum is closest to target. Return the sum of the three integers. You may assume that each input would have exactly one solution.
    /// 
    /// Example 1:
    /// Input: nums = [-1,2,1,-4], target = 1
    /// Output: 2
    /// Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
    /// 
    /// 
    /// Constraints:
    /// * 3 <= nums.length <= 10^3
    /// * -10^3 <= nums[i] <= 10^3
    /// * -10^4 <= target <= 10^4
    /// 
    /// </summary>
    public class N0016_3SumClosest
    {
        /// <summary>
        /// Two Pointers
        /// </summary>
        public class Solution1
        {
            public int ThreeSumClosest(int[] nums, int target)
            {
                int diff = int.MaxValue;
                Array.Sort(nums);
                for (int i = 0; i < nums.Length - 2 && diff != 0; i++)
                {
                    int left = i + 1, right = nums.Length - 1;
                    while (left < right)
                    {
                        var sum = nums[left] + nums[right] + nums[i];
                        var temp = sum - target;
                        if (Math.Abs(temp) < Math.Abs(diff))
                        {
                            diff = temp;
                        }
                        if (temp > 0)
                        {
                            right--;
                        }
                        else
                        {
                            left++;
                        }
                    }
                }
                return diff + target;
            }
        }

        /// <summary>
        /// Binary Search
        /// </summary>
        public class Solution2
        {
            public int ThreeSumClosest(int[] nums, int target)
            {
                int diff = int.MaxValue;
                Array.Sort(nums);
                for (int i = 0; i < nums.Length - 2 && diff != 0; i++)
                {
                    for (int j = i + 1; j < nums.Length - 1; j++)
                    {
                        int complement = target - nums[i] - nums[j];
                        int idx = Array.BinarySearch(nums, j + 1, nums.Length - j - 1, complement);
                        int hi = idx >= 0 ? idx : ~idx, lo = hi - 1;
                        if (hi < nums.Length && Math.Abs(complement - nums[hi]) < Math.Abs(diff))
                            diff = complement - nums[hi];
                        if (lo > j && Math.Abs(complement - nums[lo]) < Math.Abs(diff))
                            diff = complement - nums[lo];
                    }
                }
                return target - diff;
            }
        }
    }
}