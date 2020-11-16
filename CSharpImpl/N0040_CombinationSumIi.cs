using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/combination-sum-ii/
    /// 
    /// Given a collection of candidate numbers (candidates) and a target number (target), find all unique combinations in candidates where the candidate numbers sums to target.
    /// Each number in candidates may only be used once in the combination.
    /// 
    /// Note:
    /// * All numbers (including target) will be positive integers.
    /// * The solution set must not contain duplicate combinations.
    /// 
    /// Example 1:
    /// Input: candidates = [10,1,2,7,6,1,5], target = 8,
    /// A solution set is: [[1, 7], [1, 2, 5], [2, 6], [1, 1, 6]]
    /// 
    /// Example 2:
    /// Input: candidates = [2,5,2,1,2], target = 5,
    /// A solution set is: [[1,2,2], [5]]
    /// 
    /// </summary>
    public class N0040_CombinationSumIi
    {
        public class Solution1
        {
            public IList<IList<int>> CombinationSum2(int[] candidates, int target)
            {
                Array.Sort(candidates);
                return FindAll(candidates, target, 0).ToList();
            }

            private IEnumerable<IList<int>> FindAll(int[] candidates, int target, int index)
            {
                if (target < 0)
                {
                    yield break;
                }
                else if (target == 0)
                {
                    yield return new List<int>();
                }
                else
                {
                    for (int i = index; i < candidates.Length; i++)
                    {
                        if (i > index && candidates[i] == candidates[i - 1])
                            continue;

                        foreach (var ret in FindAll(candidates, target - candidates[i], i + 1))
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