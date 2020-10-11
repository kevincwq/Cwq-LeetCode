using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/swap-adjacent-in-lr-string/
    /// 
    /// In a string composed of 'L', 'R', and 'X' characters, like "RXXLRXRXL", a move consists of either replacing one occurrence of "XL" with "LX", or replacing one occurrence of "RX" with "XR". Given the starting string start and the ending string end, return True if and only if there exists a sequence of moves to transform one string to the other.
    /// 
    /// Example 1:
    /// Input: start = "X", end = "L"
    /// Output: false
    /// Explanation:
    /// We can transform start to end following these steps:
    /// RXXLRXRXL ->
    /// XRXLRXRXL ->
    /// XRLXRXRXL ->
    /// XRLXXRRXL ->
    /// XRLXXRRLX
    /// 
    /// Example 2:
    /// Input: start = "LLR", end = "RRL"
    /// Output: false
    /// 
    /// Example 3:
    /// Input: start = "XLLR", end = "LXLX"
    /// Output: false
    /// 
    /// 
    /// Constraints:
    /// * 1 <= start.length <= 10^4
    /// * start.length == end.length
    /// * Both start and end will only consist of characters in 'L', 'R', and 'X'.
    /// 
    /// </summary>
    public class N0777_SwapAdjacentInLrString
    {
        public class Solution1 {
            public bool CanTransform(string start, string end) {
                throw new NotImplementedException();
            }
        }
    }
}