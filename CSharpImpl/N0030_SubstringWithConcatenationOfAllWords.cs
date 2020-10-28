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
        public class Solution2
        {
            public int Increment(Dictionary<string, int> dict, string key, int increment = 1)
            {
                if (dict.ContainsKey(key))
                {
                    var v = dict[key] + increment;
                    dict[key] = v;
                    return v;
                }
                else
                {
                    dict[key] = increment;
                    return increment;
                }
            }

            public IList<int> FindSubstring(string s, string[] words)
            {
                var wordsCount = new Dictionary<string, int>();
                foreach (var word in words)
                {
                    Increment(wordsCount, word);
                }

                int s_len = s.Length, word_len = words[0].Length, words_len = words.Length;
                var results = new List<int>();
                for (int i = 0; i < s_len - word_len * words_len + 1; i++)
                {
                    var temp = new Dictionary<string, int>();
                    int j = 0;
                    while (j < words_len)
                    {
                        var word = s.Substring(i + j * word_len, word_len);
                        if (!wordsCount.ContainsKey(word) || Increment(temp, word) > wordsCount[word])
                        {
                            break;
                        }
                        j++;
                    }
                    if (j == words_len)
                    {
                        results.Add(i);
                    }
                }
                return results;
            }
        }
    }
}