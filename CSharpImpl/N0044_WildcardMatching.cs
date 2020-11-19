namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/wildcard-matching/
    /// 
    /// Given an input string (s) and a pattern (p), implement wildcard pattern matching with support for '?' and '*'.
    /// '?' Matches any single character. '*' Matches any sequence of characters (including the empty sequence).
    /// 
    /// The matching should cover the entire input string (not partial).
    /// Note:
    /// * s could be empty and contains only lowercase letters a-z.
    /// * p could be empty and contains only lowercase letters a-z, and characters like ? or *.
    /// Example 1:
    /// Input: s = "aa" p = "a"
    /// Output: false
    /// Explanation: "a" does not match the entire string "aa".
    /// 
    /// Example 2:
    /// Input: s = "aa" p = "*"
    /// Output: true
    /// Explanation: '*' matches any sequence.
    /// 
    /// Example 3:
    /// Input: s = "cb" p = "?a"
    /// Output: false
    /// Explanation: '?' matches 'c', but the second letter is 'a', which does not match 'b'.
    /// 
    /// Example 4:
    /// Input: s = "adceb" p = "*a*b"
    /// Output: true
    /// Explanation: The first '*' matches the empty sequence, while the second '*' matches the substring "dce".
    /// 
    /// Example 5:
    /// Input: s = "acdcb" p = "a*c?b"
    /// Output: false
    /// 
    /// Constraints:
    /// 0 <= s.length, p.length <= 2000
    /// s contains only lowercase English letters.
    /// p contains only lowercase English letters, '?' or '*'.
    /// </summary>
    public class N0044_WildcardMatching
    {
        public class Solution1
        {
            public bool IsMatch(string s, string p)
            {
                return Matches(s, 0, p, 0);
            }

            private bool Matches(string s, int si, string p, int pi)
            {
                if (si > s.Length - 1 && pi > p.Length - 1)
                {
                    return true;
                }

                if (pi > p.Length - 1 || (si > s.Length - 1 && p[pi] != '*'))
                {
                    return false;
                }

                if (p[pi] == '?')
                {
                    return Matches(s, si + 1, p, pi + 1);
                }
                else if (p[pi] == '*')
                {
                    return Matches(s, si, p, pi + 1) || (si < s.Length) && Matches(s, si + 1, p, pi);
                }
                else
                {
                    return p[pi] == s[si] && Matches(s, si + 1, p, pi + 1);
                }
            }
        }
    }
}