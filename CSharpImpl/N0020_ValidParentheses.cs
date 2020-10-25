using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/valid-parentheses/
    /// 
    /// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    /// An input string is valid if:
    /// 1. Open brackets must be closed by the same type of brackets.
    /// 2. Open brackets must be closed in the correct order.
    /// 
    /// Example 1:
    /// Input: s = "()"
    /// Output: true
    /// 
    /// Example 2:
    /// Input: s = "()[]{}"
    /// Output: true
    /// 
    /// Example 3:
    /// Input: s = "(]"
    /// Output: false
    /// 
    /// Example 4:
    /// Input: s = "([)]"
    /// Output: false
    /// 
    /// Example 5:
    /// Input: s = "{[]}"
    /// Output: true
    /// 
    /// 
    /// Constraints:
    /// * 1 <= s.length <= 10^4
    /// * s consists of parentheses only '()[]{}'.
    /// 
    /// </summary>
    public class N0020_ValidParentheses
    {
        /// <summary>
        /// Stack
        /// </summary>
        public class Solution1
        {
            public bool IsValid(string s)
            {
                if (s.Length % 2 != 0)
                    return false;

                var stack = new Stack<char>();
                foreach (var ch in s)
                {
                    if (stack.Count == 0)
                    {
                        if (ch == ')' || ch == ']' || ch == '}')
                            return false;
                        else
                            stack.Push(ch);
                    }
                    else
                    {
                        var peek = stack.Peek();
                        if ((peek == '(' && ch == ')') || (peek == '[' && ch == ']') || (peek == '{' && ch == '}'))
                        {
                            stack.Pop();
                        }
                        else
                        {
                            stack.Push(ch);
                        }
                    }
                }
                return stack.Count == 0;
            }
        }
    }
}