using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/occurrences-after-bigram/
    /// 
    /// Given words first and second, consider occurrences in some text of the form "first second third", where second comes immediately after first, and third comes immediately after second.
    /// For each such occurrence, add "third" to the answer, and return the answer.
    /// 
    /// Example 1:
    /// Input: text = "alice is a good girl she is a good student", first = "a", second = "good"
    /// Output: ["girl","student"]
    /// 
    /// Example 2:
    /// Input: text = "we will we will rock you", first = "we", second = "will"
    /// Output: ["we","rock"]
    /// 
    /// 
    /// Note:
    /// 1. 1 <= text.length <= 1000
    /// 2. text consists of space separated words, where each word consists of lowercase English letters.
    /// 3. 1 <= first.length, second.length <= 10
    /// 4. first and second consist of lowercase English letters.
    /// 
    /// </summary>
    public class N1078_OccurrencesAfterBigram
    {
        public class Solution1 {
            public string[] FindOcurrences(string text, string first, string second) {
                throw new NotImplementedException();
            }
        }
    }
}