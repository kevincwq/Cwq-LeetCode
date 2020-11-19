using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/permutations-ii/
    /// 
    /// Given a collection of numbers that might contain duplicates, return all possible unique permutations.
    /// Example:
    /// Input: [1,1,2]
    /// Output: [ [1,1,2], [1,2,1], [2,1,1] ]
    /// 
    /// </summary>
    public class N0047_PermutationsIi
    {
        public class Solution1
        {
            public IList<IList<int>> PermuteUnique(int[] nums)
            {
                var result = new List<IList<int>>();
                Array.Sort(nums);
                if (nums.Length > 0)
                {
                    result.Add(new List<int>() { nums[0] });
                }
                for (int i = 1; i < nums.Length; i++)
                {
                    var count = result.Count;
                    for (int k = 0; k < count; k++)
                    {
                        var item = result[k];
                        for (int j = item.Count - 1; j >= 0; j--)
                        {
                            if (item[j] != nums[i])
                            {
                                var newItem = new List<int>(item);
                                newItem.Insert(j, nums[i]);
                                result.Add(newItem);
                            }
                        }
                        item.Add(nums[i]);
                    }
                }
                return result;
            }
        }
    }
}