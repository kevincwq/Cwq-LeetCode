using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/word-ladder-ii/
    /// 
    /// Given two words (beginWord and endWord), and a dictionary's word list, find all shortest transformation sequence(s) from beginWord to endWord, such that:
    /// 1. Only one letter can be changed at a time
    /// 2. Each transformed word must exist in the word list. Note that beginWord is not a transformed word.
    /// Note:
    /// * Return an empty list if there is no such transformation sequence.
    /// * All words have the same length.
    /// * All words contain only lowercase alphabetic characters.
    /// * You may assume no duplicates in the word list.
    /// * You may assume beginWord and endWord are non-empty and are not the same.
    /// Example 1:
    /// Input: beginWord = "hit", endWord = "cog", wordList = ["hot","dot","dog","lot","log","cog"]
    /// Output: [ ["hit","hot","dot","dog","cog"],   ["hit","hot","lot","log","cog"] ]
    /// 
    /// Example 2:
    /// Input: beginWord = "hit" endWord = "cog" wordList = ["hot","dot","dog","lot","log"]
    /// Output: []
    /// Explanation: The endWord "cog" is not in wordList, therefore no possible transformation.
    /// 
    /// 
    /// </summary>
    public class N0126_WordLadderIi
    {
        public class Solution1 {
            public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList) {
                throw new NotImplementedException();
            }
        }
    }
}