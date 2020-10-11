using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/design-add-and-search-words-data-structure/
    /// 
    /// Design a data structure that supports adding new words and finding if a string matches any previously added string.
    /// Implement the WordDictionary class:
    /// * WordDictionary() Initializes the object.
    /// * void addWord(word) Adds word to the data structure, it can be matched later.
    /// * bool search(word) Returns true if there is any string in the data structure that matches word or false otherwise. word may contain dots '.' where dots can be matched with any letter.
    /// 
    /// Example:
    /// Input
    /// ["WordDictionary","addWord","addWord","addWord","search","search","search","search"]
    /// [[],["bad"],["dad"],["mad"],["pad"],["bad"],[".ad"],["b.."]]
    /// Output
    /// [null,null,null,null,false,true,true,true]
    /// Explanation
    /// WordDictionary wordDictionary = new WordDictionary();
    /// wordDictionary.addWord("bad");
    /// wordDictionary.addWord("dad");
    /// wordDictionary.addWord("mad");
    /// wordDictionary.search("pad"); // return False
    /// wordDictionary.search("bad"); // return True
    /// wordDictionary.search(".ad"); // return True
    /// wordDictionary.search("b.."); // return True
    /// 
    /// 
    /// Constraints:
    /// * 1 <= word.length <= 500
    /// * word in addWord consists lower-case English letters.
    /// * word in search consist of  '.' or lower-case English letters.
    /// * At most 50000 calls will be made to addWord and search.
    /// 
    /// </summary>
    public class N0211_DesignAddAndSearchWordsDataStructure
    {
        public class WordDictionary {
        
            /** Initialize your data structure here. */
            public WordDictionary() {
                throw new NotImplementedException();
            }
            
            /** Adds a word into the data structure. */
            public void AddWord(string word) {
                throw new NotImplementedException();
            }
            
            /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
            public bool Search(string word) {
                throw new NotImplementedException();
            }
        }
        
        /**
         * Your WordDictionary object will be instantiated and called as such:
         * WordDictionary obj = new WordDictionary();
         * obj.AddWord(word);
         * bool param_2 = obj.Search(word);
         */
    }
}