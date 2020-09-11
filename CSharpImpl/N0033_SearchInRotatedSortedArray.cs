namespace CSharpImpl
{
    public class N0033_SearchInRotatedSortedArray
    {
        // 33. Search in Rotated Sorted Array
        // https://leetcode.com/problems/search-in-rotated-sorted-array/

        //Given an integer array nums sorted in ascending order, and an integer target.
        //Suppose that nums is rotated at some pivot unknown to you beforehand(i.e., [0,1,2,4,5,6,7] might become [4,5,6,7,0,1,2]).
        //You should search for target in nums and if you found return its index, otherwise return -1.

        //Example 1:
        //Input: nums = [4,5,6,7,0,1,2], target = 0
        //Output: 4

        //Example 2:
        //Input: nums = [4,5,6,7,0,1,2], target = 3
        //Output: -1

        //Example 3:
        //Input: nums = [1], target = 0
        //Output: -1 

        //Constraints:
        //1 <= nums.length <= 5000
        //-10^4 <= nums[i] <= 10^4
        //All values of nums are unique.
        //nums is guranteed to be rotated at some pivot.
        //-10^4 <= target <= 10^4

        public class Solution1
        {
            public int Search(int[] nums, int target)
            {
                int i = 0, j = nums.Length - 1;
                while (i < j)
                {
                    if (nums[i] == target)
                        return i;
                    if (nums[j] == target)
                        return j;
                    int m = (i + j) / 2;
                    if (m == i)
                        break;
                    if (nums[m] == target)
                        return m;

                    if (nums[i] < target && target < nums[m])
                    {
                        j = m;
                        continue;
                    }
                    if (nums[m] < target && target < nums[j])
                    {
                        i = m;
                        continue;
                    }
                    if (nums[i] > nums[m] && (nums[i] < target || nums[m] > target))
                    {
                        j = m;
                        continue;
                    }
                    if (nums[m] > nums[j] && (nums[m] < target || nums[j] > target))
                    {
                        i = m;
                        continue;
                    }
                    break;
                }
                return nums[i] != target ? -1 : i;
            }
        }
    }
}
