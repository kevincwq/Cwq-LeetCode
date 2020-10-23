using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/4sum/
    /// 
    /// Given an array nums of n integers and an integer target, are there elements a, b, c, and d in nums such that a + b + c + d = target? Find all unique quadruplets in the array which gives the sum of target.
    /// Notice that the solution set must not contain duplicate quadruplets.
    /// 
    /// Example 1:
    /// Input: nums = [1,0,-1,0,-2,2], target = 0
    /// Output: [[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]
    /// 
    /// Example 2:
    /// Input: nums = [], target = 0
    /// Output: []
    /// 
    /// 
    /// Constraints:
    /// * 0 <= nums.length <= 200
    /// * -10^9 <= nums[i] <= 10^9
    /// * -10^9 <= target <= 10^9
    /// 
    /// </summary>
    public class N0018_4Sum
    {
        public class Solution1
        {
            public IList<IList<int>> FourSum(int[] nums, int target)
            {
                Array.Sort(nums);
                return NSum(nums, 0, 4, target).ToList();
            }

            private IEnumerable<IList<int>> NSum(int[] nums, int startIndex, int intergerNum, int target)
            {
                if (intergerNum > 2)
                {
                    int pre = int.MinValue;
                    for (int i = startIndex; i < nums.Length - intergerNum + 1; i++)
                    {
                        if (nums[i] == pre)
                            continue;
                        pre = nums[i];
                        foreach (var res in NSum(nums, i + 1, intergerNum - 1, target - pre))
                        {
                            res.Insert(0, pre);
                            yield return res;
                        }
                    }
                }
                else
                {
                    int lo = startIndex, hi = nums.Length - 1;
                    while (lo < hi)
                    {
                        int lov = nums[lo], hiv = nums[hi];
                        if (lov + lov > target || hiv + hiv < target)
                            break;

                        var sum = lov + hiv;
                        if (sum < target || (lo > startIndex || lov == nums[lo - 1]))
                            lo++;
                        else if (sum > target || (hi < nums.Length - 1 && hiv == nums[hi + 1]))
                            hi--;
                        else
                        {
                            yield return new List<int> { lov, hiv };
                            lo++;
                            hi--;
                        }
                    }
                }
            }
        }
    }
}