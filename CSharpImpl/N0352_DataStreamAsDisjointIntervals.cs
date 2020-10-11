using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/data-stream-as-disjoint-intervals/
    /// 
    /// Given a data stream input of non-negative integers a_1, a_2, ..., a_n, ..., summarize the numbers seen so far as a list of disjoint intervals.
    /// For example, suppose the integers from the data stream are 1, 3, 7, 2, 6, ..., then the summary will be:
    /// [1, 1]
    /// [1, 1], [3, 3]
    /// [1, 1], [3, 3], [7, 7]
    /// [1, 3], [7, 7]
    /// [1, 3], [6, 7]
    /// 
    /// 
    /// Follow up:
    /// What if there are lots of merges and the number of disjoint intervals are small compared to the data stream's size?
    /// 
    /// </summary>
    public class N0352_DataStreamAsDisjointIntervals
    {
        public class SummaryRanges {
        
            /** Initialize your data structure here. */
            public SummaryRanges() {
                throw new NotImplementedException();
            }
            
            public void AddNum(int val) {
                throw new NotImplementedException();
            }
            
            public int[][] GetIntervals() {
                throw new NotImplementedException();
            }
        }
        
        /**
         * Your SummaryRanges object will be instantiated and called as such:
         * SummaryRanges obj = new SummaryRanges();
         * obj.AddNum(val);
         * int[][] param_2 = obj.GetIntervals();
         */
    }
}