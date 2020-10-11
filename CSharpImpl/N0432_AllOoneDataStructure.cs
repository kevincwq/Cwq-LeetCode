using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/all-oone-data-structure/
    /// 
    /// Implement a data structure supporting the following operations:
    /// 
    /// 1. Inc(Key) - Inserts a new key with value 1. Or increments an existing key by 1. Key is guaranteed to be a non-empty string.
    /// 2. Dec(Key) - If Key's value is 1, remove it from the data structure. Otherwise decrements an existing key by 1. If the key does not exist, this function does nothing. Key is guaranteed to be a non-empty string.
    /// 3. GetMaxKey() - Returns one of the keys with maximal value. If no element exists, return an empty string "".
    /// 4. GetMinKey() - Returns one of the keys with minimal value. If no element exists, return an empty string "".
    /// Challenge: Perform all these in O(1) time complexity.
    /// 
    /// 
    /// </summary>
    public class N0432_AllOoneDataStructure
    {
        public class AllOne {
        
            /** Initialize your data structure here. */
            public AllOne() {
                throw new NotImplementedException();
            }
            
            /** Inserts a new key <Key> with value 1. Or increments an existing key by 1. */
            public void Inc(string key) {
                throw new NotImplementedException();
            }
            
            /** Decrements an existing key by 1. If Key's value is 1, remove it from the data structure. */
            public void Dec(string key) {
                throw new NotImplementedException();
            }
            
            /** Returns one of the keys with maximal value. */
            public string GetMaxKey() {
                throw new NotImplementedException();
            }
            
            /** Returns one of the keys with Minimal value. */
            public string GetMinKey() {
                throw new NotImplementedException();
            }
        }
        
        /**
         * Your AllOne object will be instantiated and called as such:
         * AllOne obj = new AllOne();
         * obj.Inc(key);
         * obj.Dec(key);
         * string param_3 = obj.GetMaxKey();
         * string param_4 = obj.GetMinKey();
         */
    }
}