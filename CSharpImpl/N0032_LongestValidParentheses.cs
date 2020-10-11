using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/longest-valid-parentheses/
    /// 
    /// Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.
    /// 
    /// Example 1:
    /// Input: s = "(()"
    /// Output: 2
    /// Explanation: The longest valid parentheses substring is "()".
    /// 
    /// Example 2:
    /// Input: s = ")()())"
    /// Output: 4
    /// Explanation: The longest valid parentheses substring is "()()".
    /// 
    /// Example 3:
    /// Input: s = ""
    /// Output: 0
    /// 
    /// 
    /// Constraints:
    /// * 0 <= s.length <= 3 * 10^4
    /// * s[i] is '(', or ')'.
    /// 
    /// </summary>
    public class N0032_LongestValidParentheses
    {
        public class Solution1
        {
            public int LongestValidParentheses(string s)
            {
                if (s == null || s.Length < 2)
                {
                    return 0;
                }

                List<int> indexes = new List<int>();
                for (int i = 0; i < s.Length - 1; i++)
                {
                    // find a pair and expand
                    if (s[i] == '(' && s[i + 1] == ')')
                    {
                        int j = i, k = i + 1;
                        Expand(s, ref j, ref k);
                        indexes.Add(j);
                        indexes.Add(k);
                        i = k;
                    }
                }

                // merge found sections and expand
                int merge;
                do
                {
                    merge = 0;
                    int len = indexes.Count / 2;
                    for (int i = len - 2; i >= 0; i--)
                    {
                        int i2 = 2 * i;
                        if (indexes[i2 + 1] >= indexes[i2 + 2] - 1)
                        {
                            int j = Math.Min(indexes[i2], indexes[i2 + 2]);
                            int k = Math.Max(indexes[i2 + 1], indexes[i2 + 3]);
                            // expand if merge happened
                            Expand(s, ref j, ref k);
                            indexes[i2] = j;
                            indexes[i2 + 1] = k;
                            indexes.RemoveAt(i2 + 3);
                            indexes.RemoveAt(i2 + 2);
                            merge++;
                        }
                    }

                } while (merge > 0);

                int result = 0;
                for (int i = 0; i < indexes.Count - 1; i += 2)
                {
                    var c = indexes[i + 1] - indexes[i] + 1;
                    if (c > result)
                    {
                        result = c;
                    }
                }
                return result;
            }

            private void Expand(string s, ref int i, ref int j)
            {
                if (i > 0 && j < s.Length - 1 && s[i - 1] == '(' && s[j + 1] == ')')
                {
                    i = i - 1;
                    j = j + 1;
                    Expand(s, ref i, ref j);
                }
                else if (j < s.Length - 2 && s[j + 1] == '(' && s[j + 2] == ')')
                {
                    j = j + 2;
                    Expand(s, ref i, ref j);
                }
                else if (i > 1 && s[i - 2] == '(' && s[i - 1] == ')')
                {
                    i = i - 2;
                    Expand(s, ref i, ref j);
                }
            }
        }

        public class Solution2
        {
            // dynamic programming
            public int LongestValidParentheses(string s)
            {
                int maxLen = 0;
                int[] dp = new int[s.Length];
                for (int i = 1; i < s.Length; i++)
                {
                    if (s[i] == ')')
                    {
                        if (s[i - 1] == '(')
                        {
                            dp[i] = (i >= 2 ? dp[i - 2] : 0) + 2;
                        }
                        else if (i > dp[i - 1] && s[i - dp[i - 1] - 1] == '(')
                        {
                            dp[i] = dp[i - 1] + ((i - dp[i - 1] - 2 >= 0) ? (dp[i - dp[i - 1] - 2]) : 0) + 2;
                        }
                    }
                    if (dp[i] > maxLen)
                    {
                        maxLen = dp[i];
                    }
                }
                return maxLen;
            }
        }

        public class Solution3
        {
            // Stack
            public int LongestValidParentheses(string s)
            {
                int maxLen = 0;
                Stack<int> stack = new Stack<int>();
                stack.Push(-1);
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(')
                    {
                        stack.Push(i);
                    }
                    else
                    {
                        stack.Pop();
                        if (stack.Count == 0)
                        {
                            stack.Push(i);
                        }
                        else
                        {
                            maxLen = Math.Max(maxLen, i - stack.Peek());
                        }
                    }
                }
                return maxLen;
            }
        }

        public class Solution4
        {
            // two pointers
            public int LongestValidParentheses(string s)
            {
                int left = 0, right = 0, maxlength = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(')
                    {
                        left++;
                    }
                    else
                    {
                        right++;
                    }
                    if (left == right)
                    {
                        maxlength = Math.Max(maxlength, 2 * right);
                    }
                    else if (right >= left)
                    {
                        left = right = 0;
                    }
                }
                left = right = 0;
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] == '(')
                    {
                        left++;
                    }
                    else
                    {
                        right++;
                    }
                    if (left == right)
                    {
                        maxlength = Math.Max(maxlength, 2 * left);
                    }
                    else if (left >= right)
                    {
                        left = right = 0;
                    }
                }
                return maxlength;
            }
        }
    }
}