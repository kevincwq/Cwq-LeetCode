using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/maximum-number-of-events-that-can-be-attended/
    /// 
    /// Given an array of events where events[i] = [startDay_i, endDay_i]. Every event i starts at startDay_i_ and ends at endDay_i.
    /// You can attend an event i at any day d where startTime_i <= d <= endTime_i. Notice that you can only attend one event at any time d.
    /// Return the maximum number of events you can attend.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2020/02/05/e1.png>]Input: events = [[1,2],[2,3],[3,4]]
    /// Output: 3
    /// Explanation: You can attend all the three events.
    /// One way to attend them all is as shown.
    /// Attend the first event on day 1.
    /// Attend the second event on day 2.
    /// Attend the third event on day 3.
    /// 
    /// Example 2:
    /// Input: events= [[1,2],[2,3],[3,4],[1,2]]
    /// Output: 4
    /// 
    /// Example 3:
    /// Input: events = [[1,4],[4,4],[2,2],[3,4],[1,1]]
    /// Output: 4
    /// 
    /// Example 4:
    /// Input: events = [[1,100000]]
    /// Output: 1
    /// 
    /// Example 5:
    /// Input: events = [[1,1],[1,2],[1,3],[1,4],[1,5],[1,6],[1,7]]
    /// Output: 7
    /// 
    /// 
    /// Constraints:
    /// * 1 <= events.length <= 10^5
    /// * events[i].length == 2
    /// * 1 <= startDay_i <= endDay_i <= 10^5
    /// 
    /// </summary>
    public class N1353_MaximumNumberOfEventsThatCanBeAttended
    {
        public class Solution1 {
            public int MaxEvents(int[][] events) {
                throw new NotImplementedException();
            }
        }
    }
}