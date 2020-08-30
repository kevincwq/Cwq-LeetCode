using System;
using System.ComponentModel;

namespace CSharpImpl
{
    public class N35_SearchInsertPosition
    {
        // 35. Search Insert Position
        // https://leetcode.com/problems/search-insert-position/

        //Given a sorted array and a target value, return the index if the target is found.
        //If not, return the index where it would be if it were inserted in order.
        //You may assume no duplicates in the array.

        //Example 1:
        //Input: [1,3,5,6], 5
        //Output: 2

        //Example 2:
        //Input: [1,3,5,6], 2
        //Output: 1

        //Example 3:
        //Input: [1,3,5,6], 7
        //Output: 4

        //Example 4:
        //Input: [1,3,5,6], 0
        //Output: 0

        public class Solution1
        {
            // Binary Search
            public int SearchInsert(int[] nums, int target)
            {
                return FindTarget(nums, target);
            }

            private int FindTarget(int[] nums, int target)
            {
                if (nums.Length == 0)
                    return 0;
                int l = 0, r = nums.Length;
                while (l < r)
                {
                    int m = (l + r) / 2;
                    if (nums[m] >= target)
                    {
                        r = m;
                    }
                    else
                    {
                        l = m + 1;
                    }
                }
                return l;
            }
        }
    }
}
