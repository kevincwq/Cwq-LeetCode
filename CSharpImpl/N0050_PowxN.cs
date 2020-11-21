using System;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/powx-n/
    /// 
    /// Implement pow(x, n)<http://www.cplusplus.com/reference/valarray/pow/>, which calculates x raised to the power n (i.e. x^n).
    /// 
    /// Example 1:
    /// Input: x = 2.00000, n = 10
    /// Output: 1024.00000
    /// 
    /// Example 2:
    /// Input: x = 2.10000, n = 3
    /// Output: 9.26100
    /// 
    /// Example 3:
    /// Input: x = 2.00000, n = -2
    /// Output: 0.25000
    /// Explanation: 2^-2 = 1/2^2 = 1/4 = 0.25
    /// 
    /// 
    /// Constraints:
    /// * -100.0 < x < 100.0
    /// * -2^31 <= n <= 2^31-1
    /// * -10^4 <= x^n <= 10^4
    /// 
    /// </summary>
    public class N0050_PowxN
    {
        public class Solution1
        {
            public double MyPow(double x, int n)
            {
                if (Math.Abs(x - 0.0d) < double.Epsilon)
                {
                    return 0;
                }
                else if (Math.Abs(x - 1) < double.Epsilon)
                {
                    return 1;
                }
                else if (Math.Abs(x + 1) < double.Epsilon)
                {
                    return n % 2 == 0 ? 1 : -1;
                }
                else
                {
                    var v = Pow(x, Math.Abs(n));
                    return n > 0 ? v : 1 / v;
                }
            }

            private double Pow(double x, int n)
            {
                if (n == 0)
                {
                    return 1;
                }
                if (n == 1)
                {
                    return x;
                }
                else if (n == 2)
                {
                    return x * x;
                }
                else
                {
                    var v = Pow(x, n / 2);
                    return v * v * Pow(x, n % 2);
                }
            }
        }
    }
}