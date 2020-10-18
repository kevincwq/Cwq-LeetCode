using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/regular-expression-matching/
    /// 
    /// Given an input string (s) and a pattern (p), implement regular expression matching with support for '.' and '*' where:
    /// * '.' Matches any single character.​​​​
    /// * '*' Matches zero or more of the preceding element.
    /// The matching should cover the entire input string (not partial).
    /// 
    /// Example 1:
    /// Input: s = "aa", p = "a"
    /// Output: false
    /// Explanation: "a" does not match the entire string "aa".
    /// 
    /// Example 2:
    /// Input: s = "aa", p = "a*"
    /// Output: true
    /// Explanation: '*' means zero or more of the preceding element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".
    /// 
    /// Example 3:
    /// Input: s = "ab", p = ".*"
    /// Output: true
    /// Explanation: ".*" means "zero or more (*) of any character (.)".
    /// 
    /// Example 4:
    /// Input: s = "aab", p = "c*a*b"
    /// Output: true
    /// Explanation: c can be repeated 0 times, a can be repeated 1 time. Therefore, it matches "aab".
    /// 
    /// Example 5:
    /// Input: s = "mississippi", p = "mis*is*p*."
    /// Output: false
    /// 
    /// 
    /// Constraints:
    /// * 0 <= s.length <= 20
    /// * 0 <= p.length <= 30
    /// * s contains only lowercase English letters.
    /// * p contains only lowercase English letters, '.', and '*'.
    /// 
    /// </summary>
    public class N0010_RegularExpressionMatching
    {
        /// <summary>
        /// Recursion
        /// </summary>
        public class Solution1
        {
            public bool IsMatch(string s, string p)
            {
                return IsMatch(s, 0, p, 0);
            }

            public bool IsMatch(string s, int s_index, string p, int p_index)
            {
                if (p_index == p.Length)
                {
                    return s_index == s.Length;
                }

                var p_ch = p[p_index];
                var first_match = s_index < s.Length && (p_ch == s[s_index] || p_ch == '.');
                if (p_index + 1 < p.Length && p[p_index + 1] == '*')
                {
                    return IsMatch(s, s_index, p, p_index + 2) ||
                        (first_match && IsMatch(s, s_index + 1, p, p_index));
                }
                else
                {
                    return first_match && IsMatch(s, s_index + 1, p, p_index + 1);
                }
            }
        }

        /// <summary>
        /// Dynamic Programming - Top-Down
        /// </summary>
        public class Solution2
        {
            int[,] memo;

            public bool IsMatch(string s, string p)
            {
                memo = new int[s.Length + 1, p.Length + 1];
                return IsMatch(s, 0, p, 0);
            }

            private bool IsMatch(string s, int s_index, string p, int p_index)
            {
                if (memo[s_index, p_index] != 0)
                {
                    return memo[s_index, p_index] > 0;
                }

                bool ans;
                if (p_index == p.Length)
                {
                    ans = s_index == s.Length;
                }
                else
                {
                    var p_ch = p[p_index];
                    var first_match = s_index < s.Length && (p_ch == s[s_index] || p_ch == '.');
                    if (p_index + 1 < p.Length && p[p_index + 1] == '*')
                    {
                        ans = IsMatch(s, s_index, p, p_index + 2) ||
                            (first_match && IsMatch(s, s_index + 1, p, p_index));
                    }
                    else
                    {
                        ans = first_match && IsMatch(s, s_index + 1, p, p_index + 1);
                    }
                }
                memo[s_index, p_index] = ans ? 1 : -1;
                return ans;
            }
        }

        /// <summary>
        /// Dynamic Programming - Bottom-Up
        /// </summary>
        public class Solution3
        {
            public bool IsMatch(string s, string p)
            {
                bool[,] dp = new bool[s.Length + 1, p.Length + 1];
                dp[s.Length, p.Length] = true;
                for (int i = s.Length; i >= 0; i--)
                {
                    for (int j = p.Length - 1; j >= 0; j--)
                    {
                        var first_match = i < s.Length && (p[j] == s[i] || p[j] == '.');
                        if (j + 1 < p.Length && p[j + 1] == '*')
                        {
                            dp[i, j] = dp[i, j + 2] || (first_match && dp[i + 1, j]);
                        }
                        else
                        {
                            dp[i, j] = first_match && dp[i + 1, j + 1];
                        }
                    }
                }
                return dp[0, 0];
            }
        }
    }
}