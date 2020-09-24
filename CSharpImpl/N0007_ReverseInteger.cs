using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    public class N0007_ReverseInteger
    {
        // 7. Reverse Integer
        // https://leetcode.com/problems/reverse-integer/
        //Given a 32-bit signed integer, reverse digits of an integer.

        //Example 1:
        //Input: 123
        //Output: 321

        //Example 2:
        //Input: -123
        //Output: -321

        //Example 3:
        //Input: 120
        //Output: 21

        //Note:
        //Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−2^31,  2^31−1].
        //For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.

        /// <summary>
        /// Reverse string
        /// </summary>
        public class Solution1
        {
            public int Reverse(int x)
            {
                var sign = x > 0;
                var digits = x.ToString().Trim('-');
                char[] charArray = digits.ToCharArray();
                Array.Reverse(charArray);
                var rev = new string(charArray);
                if (int.TryParse(rev, out int result))
                {
                    return sign ? result : -result;
                }
                return 0;
            }
        }

        /// <summary>
        /// Pop and Push Digits & Check before Overflow
        /// </summary>
        public class Solution2
        {
            public int Reverse(int x)
            {
                int rev = 0;
                while (x != 0)
                {
                    int pop = x % 10;
                    x /= 10;
                    if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7)) return 0;
                    if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && pop < -8)) return 0;
                    rev = rev * 10 + pop;
                }
                return rev;
            }
        }
    }
}
