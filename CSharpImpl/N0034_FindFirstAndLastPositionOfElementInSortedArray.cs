using System;
using System.ComponentModel;

namespace CSharpImpl
{
    public class N0034_FindFirstAndLastPositionOfElementInSortedArray
    {
        // 34. Find First and Last Position of Element in Sorted Array
        // https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/

        //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.
        //Your algorithm's runtime complexity must be in the order of O(log n).
        //If the target is not found in the array, return [-1, -1].

        //Example 1:
        //Input: nums = [5, 7, 7, 8, 8, 10], target = 8
        //Output: [3,4]

        //Example 2:
        //Input: nums = [5, 7, 7, 8, 8, 10], target = 6
        //Output: [-1,-1]

        //Constraints:
        //0 <= nums.length <= 10^5
        //-10^9 <= nums[i] <= 10^9
        //nums is a non decreasing array.
        //-10^9 <= target <= 10^9

        public class Solution1
        {
            // Binary Search
            public int[] SearchRange(int[] nums, int target)
            {
                var left = FindTarget(nums, target, true);
                if (left == -1)
                    return new int[] { -1, -1 };
                var right = FindTarget(nums, target, false);
                return new int[] { left, right };
            }

            private int FindTarget(int[] nums, int target, bool left)
            {
                if (nums.Length == 0)
                    return -1;
                int l = 0, r = nums.Length - 1;
                while (l + 1 < r)
                {
                    int m = (l + r) / 2;
                    if (nums[m] > target || (left && nums[m] == target))
                    {
                        r = m;
                    }
                    else
                    {
                        l = m;
                    }
                }

                if (left)
                {
                    if (nums[l] == target)
                        return l;
                    if (nums[r] == target)
                        return r;
                }
                else
                {
                    if (nums[r] == target)
                        return r;
                    if (nums[l] == target)
                        return l;
                }

                return -1;
            }
        }
    }
}
