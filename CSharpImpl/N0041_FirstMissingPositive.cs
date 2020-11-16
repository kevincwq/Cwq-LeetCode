using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/first-missing-positive/
    /// 
    /// Given an unsorted integer array, find the smallest missing positive integer.
    /// Example 1:
    /// Input: [1,2,0]
    /// Output: 3
    /// 
    /// Example 2:
    /// Input: [3,4,-1,1]
    /// Output: 2
    /// 
    /// Example 3:
    /// Input: [7,8,9,11,12]
    /// Output: 1
    /// 
    /// Follow up:
    /// Your algorithm should run in O(n) time and uses constant extra space.
    /// 
    /// Constraints:
    /// 0 <= nums.length <= 300
    /// -2^31 <= nums[i] <= 2^31 - 1
    /// </summary>
    public class N0041_FirstMissingPositive
    {
        /// <summary>
        /// Brute force
        /// </summary>
        public class Solution1
        {
            public int FirstMissingPositive(int[] nums)
            {
                var dict = new HashSet<int>(nums);
                int i = 1;
                while (dict.Contains(i))
                {
                    i++;
                }
                return i;
            }
        }

        /// <summary>
        /// Put each number in its right place,
        /// thenf find the first place its number is not right.
        /// </summary>
        public class Solution2
        {
            public int FirstMissingPositive(int[] nums)
            {
                var n = nums.Length;
                for (int i = 0; i < n; i++)
                {
                    while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
                        Swap(nums, i, nums[i] - 1);
                }

                for (int i = 0; i < n; i++)
                {
                    if (nums[i] != i + 1)
                        return i + 1;
                }

                return n + 1;
            }

            private void Swap(int[] nums, int v1, int v2)
            {
                var t = nums[v1];
                nums[v1] = nums[v2];
                nums[v2] = t;
            }
        }
    }
}