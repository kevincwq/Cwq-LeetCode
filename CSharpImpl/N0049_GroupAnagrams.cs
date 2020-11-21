using System.Collections.Generic;
using System.Linq;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/group-anagrams/
    /// 
    /// Given an array of strings strs, group the anagrams together. You can return the answer in any order.
    /// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
    /// 
    /// Example 1:
    /// Input: strs = ["eat","tea","tan","ate","nat","bat"]
    /// Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
    /// 
    /// Example 2:
    /// Input: strs = [""]
    /// Output: [[""]]
    /// 
    /// Example 3:
    /// Input: strs = ["a"]
    /// Output: [["a"]]
    /// 
    /// 
    /// Constraints:
    /// * 1 <= strs.length <= 10^4
    /// * 0 <= strs[i].length <= 100
    /// * strs[i] consists of lower-case English letters.
    /// 
    /// </summary>
    public class N0049_GroupAnagrams
    {
        public class Solution1
        {
            public IList<IList<string>> GroupAnagrams(string[] strs)
            {
                var dict = new Dictionary<string, IList<string>>();

                foreach (var str in strs)
                {
                    var key = string.Concat(str.OrderBy(c => c));
                    if (dict.ContainsKey(key))
                    {
                        dict[key].Add(str);
                    }
                    else
                    {
                        dict.Add(key, new List<string> { str });
                    }
                }

                return dict.Values.OrderBy(v => v.Count).ToList();
            }
        }
    }
}