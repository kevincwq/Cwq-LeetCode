using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/longest-common-prefix/
    /// 
    /// Write a function to find the longest common prefix string amongst an array of strings.
    /// If there is no common prefix, return an empty string "".
    /// 
    /// Example 1:
    /// Input: strs = ["flower","flow","flight"]
    /// Output: "fl"
    /// 
    /// Example 2:
    /// Input: strs = ["dog","racecar","car"]
    /// Output: ""
    /// Explanation: There is no common prefix among the input strings.
    /// 
    /// 
    /// Constraints:
    /// * 0 <= strs.length <= 200
    /// * 0 <= strs[i].length <= 200
    /// * strs[i] consists of only lower-case English letters.
    /// 
    /// </summary>
    public class N0014_LongestCommonPrefix
    {
        /// <summary>
        /// Vertical scanning
        /// </summary>
        public class Solution1
        {
            public string LongestCommonPrefix(string[] strs)
            {
                if (strs.Length == 0)
                    return string.Empty;

                var sb = new StringBuilder();
                int index = 0;
                while (true)
                {
                    if (index == strs[0].Length)
                        return sb.ToString();
                    var ch = strs[0][index];
                    for (int j = 1; j < strs.Length; j++)
                    {
                        if (index == strs[j].Length || strs[j][index] != ch)
                            return sb.ToString();
                    }
                    sb.Append(ch);
                    index++;
                }
            }
        }
    }
}