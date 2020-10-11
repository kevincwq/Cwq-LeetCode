using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/implement-rand10-using-rand7/
    /// 
    /// Given the API rand7() that generates a uniform random integer in the range [1, 7], write a function rand10() that generates a uniform random integer in the range [1, 10]. You can only call the API rand7(), and you shouldn't call any other API. Please do not use a language's built-in random API.
    /// Each test case will have one internal argument n, the number of times that your implemented function rand10() will be called while testing. Note that this is not an argument passed to rand10().
    /// Follow up:
    /// * What is the expected value<https://en.wikipedia.org/wiki/Expected_value> for the number of calls to rand7() function?
    /// * Could you minimize the number of calls to rand7()?
    /// 
    /// Example 1:
    /// Input: n = 1
    /// Output: [2]
    /// 
    /// Example 2:
    /// Input: n = 2
    /// Output: [2,8]
    /// 
    /// Example 3:
    /// Input: n = 3
    /// Output: [3,8,10]
    /// 
    /// 
    /// Constraints:
    /// * 1 <= n <= 10^5
    /// 
    /// </summary>
    public class N0470_ImplementRand10UsingRand7
    {
        /**
         * The Rand7() API is already defined in the parent class SolBase.
         * public int Rand7();
         * @return a random integer in the range 1 to 7
         */
        public class Solution1 : SolBase {
            public int Rand10() {
                throw new NotImplementedException();
            }

            public int Rand7()
            {
                throw new NotImplementedException();
            }
        }
    }
}