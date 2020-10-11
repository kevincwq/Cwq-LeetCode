using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/peeking-iterator/
    /// 
    /// Given an Iterator class interface with methods: next() and hasNext(), design and implement a PeekingIterator that support the peek() operation -- it essentially peek() at the element that will be returned by the next call to next().
    /// Example:
    /// Assume that the iterator is initialized to the beginning of the list: [1,2,3]. Call next() gets you 1, the first element in the list. Now you call peek() and it returns 2, the next element. Calling next() after that still return 2. You call next() the final time and it returns 3, the last element. Calling hasNext() after that should return false.
    /// 
    /// Follow up: How would you extend your design to be generic and work with all types, not just integer?
    /// 
    /// </summary>
    public class N0284_PeekingIterator
    {
        // C# IEnumerator interface reference:
        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8
        
        class PeekingIterator {
            // iterators refers to the first element of the array.
            public PeekingIterator(IEnumerator<int> iterator) {
                // initialize any member here.
            }
            
            // Returns the next element in the iteration without advancing the iterator.
            public int Peek() {
                throw new NotImplementedException();
            }
            
            // Returns the next element in the iteration and advances the iterator.
            public int Next() {
                throw new NotImplementedException();
            }
            
            // Returns false if the iterator is refering to the end of the array of true otherwise.
            public bool HasNext() {
        		throw new NotImplementedException();
            }
        }
    }
}