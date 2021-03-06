using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/implement-strstr/
    /// 
    /// Implement strStr()<http://www.cplusplus.com/reference/cstring/strstr/>.
    /// Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
    /// Clarification:
    /// What should we return when needle is an empty string? This is a great question to ask during an interview.
    /// For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C's strstr()<http://www.cplusplus.com/reference/cstring/strstr/> and Java's indexOf()<https://docs.oracle.com/javase/7/docs/api/java/lang/String.html#indexOf(java.lang.String)>.
    /// 
    /// Example 1:
    /// Input: haystack = "hello", needle = "ll"
    /// Output: 2
    /// 
    /// Example 2:
    /// Input: haystack = "aaaaa", needle = "bba"
    /// Output: -1
    /// 
    /// Example 3:
    /// Input: haystack = "", needle = ""
    /// Output: 0
    /// 
    /// 
    /// Constraints:
    /// * 0 <= haystack.length, needle.length <= 5 * 10^4
    /// * haystack and needle consist of only lower-case English characters.
    /// 
    /// </summary>
    public class N0028_ImplementStrstr
    {
        public class Solution1
        {
            public int StrStr(string haystack, string needle)
            {
                // return 0 when needle is an empty string
                if (string.IsNullOrEmpty(needle))
                {
                    return 0;
                }

                if (string.IsNullOrEmpty(haystack))
                {
                    return -1;
                }

                for (int i = 0; i <= haystack.Length - needle.Length; i++)
                {
                    if (haystack[i] == needle[0])
                    {
                        int j = 1;
                        while (j < needle.Length)
                        {
                            if (haystack[i + j] != needle[j])
                                break;
                            j++;
                        }
                        if (j == needle.Length)
                            return i;
                    }
                }

                return -1;
            }
        }
    }
}