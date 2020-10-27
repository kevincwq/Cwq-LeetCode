using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/substring-with-concatenation-of-all-words/
    /// 
    /// You are given a string s and an array of strings words of the same length. Return all starting indices of substring(s) in s that is a concatenation of each word in words exactly once, in any order, and without any intervening characters.
    /// You can return the answer in any order.
    /// 
    /// Example 1:
    /// Input: s = "barfoothefoobarman", words = ["foo","bar"]
    /// Output: [0,9]
    /// Explanation: Substrings starting at index 0 and 9 are "barfoo" and "foobar" respectively.
    /// The output order does not matter, returning [9,0] is fine too.
    /// 
    /// Example 2:
    /// Input: s = "wordgoodgoodgoodbestword", words = ["word","good","best","word"]
    /// Output: []
    /// 
    /// Example 3:
    /// Input: s = "barfoofoobarthefoobarman", words = ["bar","foo","the"]
    /// Output: [6,9,12]
    /// 
    /// 
    /// Constraints:
    /// * 1 <= s.length <= 10^4
    /// * s consists of lower-case English letters.
    /// * 1 <= words.length <= 5000
    /// * 1 <= words[i].length <= 30
    /// * words[i] consists of lower-case English letters.
    /// 
    /// </summary>
    public class N0030_SubstringWithConcatenationOfAllWords
    {
        public class Solution1
        {
            public IList<int> FindSubstring(string s, string[] words)
            {
                var result = new List<int>();
                if (!string.IsNullOrEmpty(s) && words != null && words.Length > 0)
                {
                    var dict = new Dictionary<string, int>();
                    foreach (var word in words)
                    {
                        if (dict.ContainsKey(word))
                        {
                            dict[word] = dict[word] + 1;
                        }
                        else
                        {
                            dict[word] = 1;
                        }
                    }
                    int wordLen = words[0].Length;
                    int len = s.Length - wordLen * words.Length;
                    for (int i = 0; i <= len; i++)
                    {
                        if (Matches(s, i, wordLen, words.Length, dict))
                        {
                            result.Add(i);
                        }
                    }
                }
                return result;
            }

            private bool Matches(string s, int index, int wordLen, int leftCount, Dictionary<string, int> dict)
            {
                if (index + wordLen > s.Length)
                {
                    return false;
                }
                var word = s.Substring(index, wordLen);
                if (dict.ContainsKey(word) && dict[word] > 0)
                {
                    if (leftCount == 1)
                    {
                        return true;
                    }
                    else
                    {
                        dict[word] = dict[word] - 1;
                        var ret = Matches(s, index + wordLen, wordLen, leftCount - 1, dict);
                        dict[word] = dict[word] + 1;
                        return ret;
                    }
                }
                return false;
            }
        }
    }
}