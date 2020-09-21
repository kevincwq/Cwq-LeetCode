using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    public class N0005_LongestPalindromicSubstring
    {
        // 5. LongestPalindromicSubstring
        // https://leetcode.com/problems/median-of-two-sorted-arrays/
        // Given a string s, find the longest palindromic substring in s.You may assume that the maximum length of s is 1000.

        //Example 1:
        //Input: "babad"
        //Output: "bab"
        //Note: "aba" is also a valid answer.

        //Example 2:
        //Input: "cbbd"
        //Output: "bb"

        /// <summary>
        /// Expand
        /// </summary>
        public class Solution1
        {
            public string LongestPalindrome(string s)
            {
                if (string.IsNullOrEmpty(s))
                    return string.Empty;

                int minIndex = 0, maxIndex = 0, len = s.Length;
                for (int i = 1; i < len; i++)
                {
                    if (i < len - 1 && s[i + 1] == s[i - 1])
                    {
                        int min = i - 1;
                        int max = i + 1;

                        Expand(s, ref min, ref max);
                        if (max - min > maxIndex - minIndex)
                        {
                            maxIndex = max;
                            minIndex = min;
                        }
                    }

                    if (s[i] == s[i - 1])
                    {
                        int min = i - 1;
                        int max = i;

                        Expand(s, ref min, ref max);
                        if (max - min > maxIndex - minIndex)
                        {
                            maxIndex = max;
                            minIndex = min;
                        }
                    }
                }
                return s.Substring(minIndex, maxIndex - minIndex + 1);
            }

            private void Expand(string s, ref int l, ref int r)
            {
                while (l - 1 > -1 && r + 1 < s.Length && s[l - 1] == s[r + 1])
                {
                    l--;
                    r++;
                }
            }
        }

        /// <summary>
        /// Not good
        /// </summary>
        public class Solution2
        {
            public string LongestPalindrome(string s)
            {
                int b = 0, max = 0;
                var len = s.Length;
                int e;
                if (len > 0)
                {
                    max = 1;
                }

                var bucket = new Dictionary<char, List<int>>();
                for (int i = 0; i < len; i++)
                {
                    var ch = s[i];
                    if (!bucket.ContainsKey(ch))
                    {
                        bucket.Add(ch, new List<int>() { i });
                    }
                    else
                    {
                        bucket[ch].Add(i);
                    }
                }

                foreach (var pari in bucket)
                {
                    var key = pari.Key;
                    var value = pari.Value;
                    for (int i = 1; i < value.Count; i++)
                    {
                        var diff = value[i] - value[i - 1];
                        if (diff == 1 || diff == 2)
                        {
                            var l = value[i - 1];
                            var r = value[i];
                            if (diff == 1)
                            {
                                while (l > 0 && s[l - 1] == key) { l--; }
                                while (r < len - 1 && s[r + 1] == key) { r++; }
                            }
                            while (l > 0 && r < len - 1 && s[l - 1] == s[r + 1])
                            {
                                l--;
                                r++;
                            }
                            if (r - l + 1 > max)
                            {
                                b = l;
                                e = r;
                                max = r - l + 1;
                            }
                        }
                    }
                }
                return s.Substring(b, max);
            }
        }
    }
}
