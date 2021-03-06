using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/maximum-length-of-a-concatenated-string-with-unique-characters/
    /// 
    /// Given an array of strings arr. String s is a concatenation of a sub-sequence of arr which have unique characters.
    /// Return the maximum possible length of s.
    /// 
    /// Example 1:
    /// Input: arr = ["un","iq","ue"]
    /// Output: 4
    /// Explanation: All possible concatenations are "","un","iq","ue","uniq" and "ique".
    /// Maximum length is 4.
    /// 
    /// Example 2:
    /// Input: arr = ["cha","r","act","ers"]
    /// Output: 6
    /// Explanation: Possible solutions are "chaers" and "acters".
    /// 
    /// Example 3:
    /// Input: arr = ["abcdefghijklmnopqrstuvwxyz"]
    /// Output: 26
    /// 
    /// 
    /// Constraints:
    /// * 1 <= arr.length <= 16
    /// * 1 <= arr[i].length <= 26
    /// * arr[i] contains only lower case English letters.
    /// 
    /// </summary>
    public class N1239_MaximumLengthOfAConcatenatedStringWithUniqueCharacters
    {
        public class Solution1 {
            public int MaxLength(IList<string> arr) {
                throw new NotImplementedException();
            }
        }
    }
}