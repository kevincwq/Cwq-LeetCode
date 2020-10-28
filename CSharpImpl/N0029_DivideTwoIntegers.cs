using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/divide-two-integers/
    /// 
    /// Given two integers dividend and divisor, divide two integers without using multiplication, division, and mod operator.
    /// Return the quotient after dividing dividend by divisor.
    /// The integer division should truncate toward zero, which means losing its fractional part. For example, truncate(8.345) = 8 and truncate(-2.7335) = -2.
    /// Note:
    /// * Assume we are dealing with an environment that could only store integers within the 32-bit signed integer range: [−2^31,  2^31 − 1]. For this problem, assume that your function returns 2^31 − 1 when the division result overflows.
    /// 
    /// Example 1:
    /// Input: dividend = 10, divisor = 3
    /// Output: 3
    /// Explanation: 10/3 = truncate(3.33333..) = 3.
    /// 
    /// Example 2:
    /// Input: dividend = 7, divisor = -3
    /// Output: -2
    /// Explanation: 7/-3 = truncate(-2.33333..) = -2.
    /// 
    /// Example 3:
    /// Input: dividend = 0, divisor = 1
    /// Output: 0
    /// 
    /// Example 4:
    /// Input: dividend = 1, divisor = 1
    /// Output: 1
    /// 
    /// 
    /// Constraints:
    /// * -2^31 <= dividend, divisor <= 2^31 - 1
    /// * divisor != 0
    /// 
    /// </summary>
    public class N0029_DivideTwoIntegers
    {
        public class Solution1
        {
            public int Divide(int dividend, int divisor)
            {
                // special case that could not use Math.Abs
                if (divisor == int.MinValue)
                {
                    return dividend == int.MinValue ? 1 : 0;
                }

                bool extra = false;
                // special case that could not use Math.Abs
                if (dividend == int.MinValue)
                {
                    // overflow return int.MaxValue
                    if (divisor == -1)
                        return int.MaxValue;

                    if (divisor > 0)
                        dividend += divisor;
                    else
                        dividend -= divisor;

                    extra = true;
                }

                var signed = dividend < 0 ^ divisor < 0;
                dividend = Math.Abs(dividend);
                divisor = Math.Abs(divisor);

                int quo = 0;
                for (int i = 31; i >= 0; i--)
                {
                    if (dividend >> i >= divisor)
                    {
                        quo |= 1 << i;
                        dividend -= divisor << i;
                    }
                }

                if (signed)
                {
                    return extra ? -quo - 1 : -quo;
                }
                else
                {
                    return extra ? quo + 1 : quo;
                }
            }
        }
    }
}