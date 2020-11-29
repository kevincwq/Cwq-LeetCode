using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/maximum-subarray/
    /// 
    /// Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
    /// Follow up: If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
    /// 
    /// Example 1:
    /// Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
    /// Output: 6
    /// Explanation: [4,-1,2,1] has the largest sum = 6.
    /// 
    /// Example 2:
    /// Input: nums = [1]
    /// Output: 1
    /// 
    /// Example 3:
    /// Input: nums = [0]
    /// Output: 0
    /// 
    /// Example 4:
    /// Input: nums = [-1]
    /// Output: -1
    /// 
    /// Example 5:
    /// Input: nums = [-2147483647]
    /// Output: -2147483647
    /// 
    /// 
    /// Constraints:
    /// * 1 <= nums.length <= 2 * 10^4
    /// * -2^31 <= nums[i] <= 2^31 - 1
    /// 
    /// </summary>
    public class N0053_MaximumSubarray
    {
        public class Solution1
        {
            public int MaxSubArray(int[] nums)
            {
                int l = -1, r = nums.Length;
                int i = l, j = r, lsum = int.MinValue, rsum = int.MinValue;
                while (i < j - 1)
                {
                    if (lsum <= rsum)
                    {
                        i++;

                        if (lsum < 0)
                        {
                            lsum = nums[i];
                            l = i;
                        }
                        else
                        {
                            lsum += nums[i];
                        }
                    }
                    else
                    {
                        j--;

                        if (rsum < 0)
                        {
                            rsum = nums[j];
                            r = j;
                        }
                        else
                        {
                            rsum += nums[j];
                        }
                    }
                }

                if (lsum >= 0 && rsum >= 0)
                    return lsum + rsum;
                else
                    return Math.Max(lsum, rsum);
            }
        }

        /// <summary>
        /// Divide and Conquer
        /// Breaks nums into two halves and find the maximum subarray sum in them recursively.
        /// Well, the most tricky part is to handle the case that the maximum subarray spans
        /// the two halves. For this case, we use a linear algorithm: starting from the middle
        /// element and move to both ends (left and right ends), record the maximum sum we have
        /// seen. In this case, the maximum sum is finally equal to the middle element plus the
        /// maximum sum of moving leftwards and the maximum sum of moving rightwards.
        /// </summary>
        public class Solution2
        {
            public int MaxSubArray(int[] nums)
            {
                return MaxSubArray(nums, 0, nums.Length - 1);
            }

            private int MaxSubArray(int[] nums, int l, int r)
            {
                if (l > r)
                {
                    return int.MinValue;
                }
                int m = l + (r - l) / 2, ml = 0, mr = 0;
                int lmax = MaxSubArray(nums, l, m - 1);
                int rmax = MaxSubArray(nums, m + 1, r);
                for (int i = m - 1, sum = 0; i >= l; i--)
                {
                    sum += nums[i];
                    ml = Math.Max(sum, ml);
                }
                for (int i = m + 1, sum = 0; i <= r; i++)
                {
                    sum += nums[i];
                    mr = Math.Max(sum, mr);
                }
                return Math.Max(Math.Max(lmax, rmax), ml + mr + nums[m]);
            }
        }

        /// <summary>
        /// Dynamic Programming
        /// The idea is to maintain a running maximum smax and a current summation sum. 
        /// When we visit each num in nums, add num to sum, 
        /// then update smax if necessary or reset sum to 0 if it becomes negative.
        /// </summary>
        public class Solution3
        {
            public int MaxSubArray(int[] nums)
            {
                int curMax = nums[0], preMax = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    preMax = Math.Max(preMax + nums[i], nums[i]);
                    curMax = Math.Max(curMax, preMax);
                }
                return curMax;
            }
        }
    }
}