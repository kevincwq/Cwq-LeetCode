using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/find-kth-bit-in-nth-binary-string/
    /// 
    /// Given two positive integers n and k, the binary string  S_n is formed as follows:
    /// * S_1 = "0"
    /// * S_i = S_i-1 + "1" + reverse(invert(S_i-1)) for i > 1
    /// Where + denotes the concatenation operation, reverse(x) returns the reversed string x, and invert(x) inverts all the bits in x (0 changes to 1 and 1 changes to 0).
    /// For example, the first 4 strings in the above sequence are:
    /// * S_1 = "0"
    /// * S_2 = "011"
    /// * S_3 = "0111001"
    /// * S_4 = "011100110110001"
    /// Return the k^th bit in S_n. It is guaranteed that k is valid for the given n.
    /// 
    /// Example 1:
    /// Input: n = 3, k = 1
    /// Output: "0"
    /// Explanation: S_3 is "0111001". The first bit is "0".
    /// 
    /// Example 2:
    /// Input: n = 4, k = 11
    /// Output: "1"
    /// Explanation: S_4 is "011100110110001". The 11th bit is "1".
    /// 
    /// Example 3:
    /// Input: n = 1, k = 1
    /// Output: "0"
    /// 
    /// Example 4:
    /// Input: n = 2, k = 3
    /// Output: "1"
    /// 
    /// 
    /// Constraints:
    /// * 1 <= n <= 20
    /// * 1 <= k <= 2^n - 1
    /// 
    /// </summary>
    public class N1545_FindKthBitInNthBinaryString
    {
        public class Solution1 {
            public char FindKthBit(int n, int k) {
                throw new NotImplementedException();
            }
        }
    }
}