using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/poor-pigs/
    /// 
    /// There are 1000 buckets, one and only one of them is poisonous, while the rest are filled with water. They all look identical. If a pig drinks the poison it will die within 15 minutes. What is the minimum amount of pigs you need to figure out which bucket is poisonous within one hour?
    /// Answer this question, and write an algorithm for the general case.
    /// 
    /// General case:
    /// If there are n buckets and a pig drinking poison will die within m minutes, how many pigs (x) you need to figure out the poisonous bucket within p minutes? There is exactly one bucket with poison.
    /// 
    /// Note:
    /// 1. A pig can be allowed to drink simultaneously on as many buckets as one would like, and the feeding takes no time.
    /// 2. After a pig has instantly finished drinking buckets, there has to be a cool down time of m minutes. During this time, only observation is allowed and no feedings at all.
    /// 3. Any given bucket can be sampled an infinite number of times (by an unlimited number of pigs).
    /// 
    /// </summary>
    public class N0458_PoorPigs
    {
        public class Solution1 {
            public int PoorPigs(int buckets, int minutesToDie, int minutesToTest) {
                throw new NotImplementedException();
            }
        }
    }
}