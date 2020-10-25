using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/generate-parentheses/
    /// 
    /// Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
    /// 
    /// Example 1:
    /// Input: n = 3
    /// Output: ["((()))","(()())","(())()","()(())","()()()"]
    /// 
    /// Example 2:
    /// Input: n = 1
    /// Output: ["()"]
    /// 
    /// 
    /// Constraints:
    /// * 1 <= n <= 8
    /// 
    /// </summary>
    public class N0022_GenerateParentheses
    {
        /// <summary>
        /// Backtracking
        /// </summary>
        public class Solution1
        {
            public IList<string> GenerateParenthesis(int n)
            {
                return GenerateParenthesis(n, 0, 0).ToList();
            }

            private IEnumerable<string> GenerateParenthesis(int n, int left, int right)
            {
                if (left == n)
                {
                    yield return new string(')', n - right);
                }
                else
                {
                    foreach (var ret in GenerateParenthesis(n, left + 1, right))
                    {
                        yield return '(' + ret;
                    }
                    if (left > right)
                    {
                        foreach(var ret in GenerateParenthesis(n, left, right+1))
                        {
                            yield return ')' + ret;
                        }
                    }
                }
            }
        }
    }
}