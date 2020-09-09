using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    public class N39_CombinationSum
    {
        // 39. Combination Sum
        // https://leetcode.com/problems/combination-sum/

        // Given a set of candidate numbers(candidates) (without duplicates) and a target number(target), find all unique combinations in candidates where the candidate numbers sums to target.
        // The same repeated number may be chosen from candidates unlimited number of times.

        // Note:
        //   All numbers (including target) will be positive integers.
        //   The solution set must not contain duplicate combinations.

        // Example 1:
        //  Input: candidates = [2, 3, 6, 7], target = 7,
        //  A solution set is:
        //  [
        //      [7],
        //      [2,2,3]
        //  ]

        // Example 2:
        //  Input: candidates = [2,3,5], target = 8,
        //  A solution set is:
        //  [
        //      [2,2,2,2],
        //      [2,3,3],
        //      [3,5]
        //  ]

        // Constraints:
        // 1 <= candidates.length <= 30
        // 1 <= candidates[i] <= 200
        // Each element of candidate is unique.
        // 1 <= target <= 500

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
    }
}
