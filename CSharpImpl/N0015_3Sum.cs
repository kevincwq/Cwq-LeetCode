using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/3sum/
    /// 
    /// Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.
    /// Notice that the solution set must not contain duplicate triplets.
    /// 
    /// Example 1:
    /// Input: nums = [-1,0,1,2,-1,-4]
    /// Output: [[-1,-1,2],[-1,0,1]]
    /// 
    /// Example 2:
    /// Input: nums = []
    /// Output: []
    /// 
    /// Example 3:
    /// Input: nums = [0]
    /// Output: []
    /// 
    /// 
    /// Constraints:
    /// * 0 <= nums.length <= 3000
    /// * -10^5 <= nums[i] <= 10^5
    /// 
    /// </summary>
    public class N0015_3Sum
    {
        public class Solution1
        {
            public IList<IList<int>> ThreeSum(int[] nums)
            {
                List<IList<int>> rets = new List<IList<int>>();

                Array.Sort(nums);
                for (int i = 0; i < nums.Length - 2; i++)
                {
                    // remove duplicates
                    if (i > 0 && nums[i] == nums[i - 1])
                        continue;

                    var target = -nums[i];
                    int left = i + 1, right = nums.Length - 1;

                    while (left < right)
                    {
                        if (2 * nums[left] > target || 2 * nums[right] < target)
                        {
                            break;
                        }

                        var sum = nums[left] + nums[right];
                        if (sum == target)
                        {
                            rets.Add(new List<int>() { -target, nums[left], nums[right] });
                            // remove duplicates
                            while (++left <= right)
                            {
                                if (nums[left] != nums[left - 1])
                                    break;
                            }
                            while (left <= --right)
                            {
                                if (nums[right] != nums[right + 1])
                                    break;
                            }
                        }
                        else if (sum < target)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }
                return rets;
            }
        }
    }
}