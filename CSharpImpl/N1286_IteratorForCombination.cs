using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/iterator-for-combination/
    /// 
    /// Design an Iterator class, which has:
    /// * A constructor that takes a string characters of sorted distinct lowercase English letters and a number combinationLength as arguments.
    /// * A function next() that returns the next combination of length combinationLength in lexicographical order.
    /// * A function hasNext() that returns True if and only if there exists a next combination.
    /// 
    /// Example:
    /// CombinationIterator iterator = new CombinationIterator("abc", 2); // creates the iterator. iterator.next(); // returns "ab"
    /// iterator.hasNext(); // returns true
    /// iterator.next(); // returns "ac"
    /// iterator.hasNext(); // returns true
    /// iterator.next(); // returns "bc"
    /// iterator.hasNext(); // returns false
    /// 
    /// 
    /// Constraints:
    /// * 1 <= combinationLength <= characters.length <= 15
    /// * There will be at most 10^4 function calls per test.
    /// * It's guaranteed that all calls of the function next are valid.
    /// 
    /// </summary>
    public class N1286_IteratorForCombination
    {
        public class CombinationIterator {
        
            public CombinationIterator(string characters, int combinationLength) {
                throw new NotImplementedException();
            }
            
            public string Next() {
                throw new NotImplementedException();
            }
            
            public bool HasNext() {
                throw new NotImplementedException();
            }
        }
        
        /**
         * Your CombinationIterator object will be instantiated and called as such:
         * CombinationIterator obj = new CombinationIterator(characters, combinationLength);
         * string param_1 = obj.Next();
         * bool param_2 = obj.HasNext();
         */
    }
}