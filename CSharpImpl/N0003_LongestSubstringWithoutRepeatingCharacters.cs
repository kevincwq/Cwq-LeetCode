using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// 
    /// Given a string s, find the length of the longest substring without repeating characters.
    /// 
    /// Example 1:
    /// Input: s = "abcabcbb"
    /// Output: 3
    /// Explanation: The answer is "abc", with the length of 3.
    /// 
    /// Example 2:
    /// Input: s = "bbbbb"
    /// Output: 1
    /// Explanation: The answer is "b", with the length of 1.
    /// 
    /// Example 3:
    /// Input: s = "pwwkew"
    /// Output: 3
    /// Explanation: The answer is "wke", with the length of 3.
    /// Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
    /// 
    /// Example 4:
    /// Input: s = ""
    /// Output: 0
    /// 
    /// 
    /// Constraints:
    /// * 0 <= s.length <= 5 * 10^4
    /// * s consists of English letters, digits, symbols and spaces.
    /// 
    /// </summary>
    public class N0003_LongestSubstringWithoutRepeatingCharacters
    {
        /// <summary>
        /// Hashset
        /// </summary>
        public class Solution1
        {
            public int LengthOfLongestSubstring(string s)
            {
                int max = 0;
                var dict = new Dictionary<char, int>();

                for (int i = 0, j = 0; j < s.Length; j++)
                {
                    var ch = s[j];
                    if (dict.ContainsKey(ch))
                    {
                        i = Math.Max(dict[ch], i);
                    }
                    max = Math.Max(max, j - i + 1);
                    dict[ch] = j + 1;
                }
                return max;
            }
        }
    }
}