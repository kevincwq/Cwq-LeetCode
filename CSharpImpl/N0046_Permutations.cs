using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/permutations/
    /// 
    /// Given a collection of distinct integers, return all possible permutations.
    /// Example:
    /// Input: [1,2,3]
    /// Output: [ [1,2,3], [1,3,2], [2,1,3], [2,3,1], [3,1,2], [3,2,1] ]
    /// 
    /// </summary>
    public class N0046_Permutations
    {
        public class Solution1
        {
            public IList<IList<int>> Permute(int[] nums)
            {
                var result = new List<IList<int>>();
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
                            var newItem = new List<int>(item);
                            newItem.Insert(j, nums[i]);
                            result.Add(newItem);
                        }
                        item.Add(nums[i]);
                    }
                }
                return result;
            }
        }
    }
}