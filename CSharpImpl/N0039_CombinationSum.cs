using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/combination-sum/
    /// 
    /// Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. You may return the combinations in any order.
    /// The same number may be chosen from candidates an unlimited number of times. Two combinations are unique if the frequency of at least one of the chosen numbers is different.
    /// It is guaranteed that the number of unique combinations that sum up to target is less than 150 combinations for the given input.
    /// 
    /// Example 1:
    /// Input: candidates = [2,3,6,7], target = 7
    /// Output: [[2,2,3],[7]]
    /// Explanation:
    /// 2 and 3 are candidates, and 2 + 2 + 3 = 7. Note that 2 can be used multiple times.
    /// 7 is a candidate, and 7 = 7.
    /// These are the only two combinations.
    /// 
    /// Example 2:
    /// Input: candidates = [2,3,5], target = 8
    /// Output: [[2,2,2,2],[2,3,3],[3,5]]
    /// 
    /// Example 3:
    /// Input: candidates = [2], target = 1
    /// Output: []
    /// 
    /// Example 4:
    /// Input: candidates = [1], target = 1
    /// Output: [[1]]
    /// 
    /// Example 5:
    /// Input: candidates = [1], target = 2
    /// Output: [[1,1]]
    /// 
    /// 
    /// Constraints:
    /// * 1 <= candidates.length <= 30
    /// * 1 <= candidates[i] <= 200
    /// * All elements of candidates are distinct.
    /// * 1 <= target <= 500
    /// 
    /// </summary>
    public class N0039_CombinationSum
    {
        /// <summary>
        /// Back-tracking - Predetermine the length scope of possible solutions
        /// </summary>
        public class Solution1
        {
            public IList<IList<int>> CombinationSum(int[] candidates, int target)
            {
                Array.Sort(candidates);

                var result = new List<IList<int>>();
                var len = (int)Math.Ceiling((float)target / candidates[candidates.Length - 1]);
                var max_len = target / candidates[0];

                while (len <= max_len)
                {
                    var nth = FindNth(candidates, target, 0, len);
                    result.AddRange(nth);
                    len++;
                }
                return result;
            }

            private IEnumerable<List<int>> FindNth(int[] candidates, int target, int index, int n)
            {
                if (target < 0)
                {
                    yield break;
                }
                if (n == 1)
                {
                    if (Array.IndexOf(candidates, target) >= index)
                    {
                        yield return new List<int>() { target };
                    }
                }
                else
                {
                    for (int i = index; i < candidates.Length; i++)
                    {
                        foreach (var ret in FindNth(candidates, target - candidates[i], i, n - 1))
                        {
                            ret.Insert(0, candidates[i]);
                            yield return ret;
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Pure Back-tracking
        /// </summary>
        public class Solution2
        {
            public IList<IList<int>> CombinationSum(int[] candidates, int target)
            {
                return FindAll(candidates, target, 0).ToList();
            }

            private IEnumerable<IList<int>> FindAll(int[] candidates, int target, int index)
            {
                if (target < 0)
                {
                    yield break;
                }
                if (target == 0)
                {
                    yield return new List<int>();
                }
                else
                {
                    for (int i = index; i < candidates.Length; i++)
                    {
                        foreach (var ret in FindAll(candidates, target - candidates[i], i))
                        {
                            ret.Insert(0, candidates[i]);
                            yield return ret;
                        }
                    }
                }
            }
        }
    }
}