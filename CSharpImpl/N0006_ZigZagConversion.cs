using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/zigzag-conversion/
    /// 
    /// The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
    /// P A H N
    /// A P L S I I G
    /// Y I R
    /// 
    /// And then read line by line: "PAHNAPLSIIGYIR"
    /// Write the code that will take a string and make this conversion given a number of rows:
    /// string convert(string s, int numRows);
    /// 
    /// 
    /// Example 1:
    /// Input: s = "PAYPALISHIRING", numRows = 3
    /// Output: "PAHNAPLSIIGYIR"
    /// 
    /// Example 2:
    /// Input: s = "PAYPALISHIRING", numRows = 4
    /// Output: "PINALSIGYAHRPI"
    /// Explanation:
    /// P I N
    /// A L S I G
    /// Y A H R
    /// P I
    /// 
    /// Example 3:
    /// Input: s = "A", numRows = 1
    /// Output: "A"
    /// 
    /// 
    /// Constraints:
    /// * 1 <= s.length <= 1000
    /// * s consists of English letters (lower-case and upper-case), ',' and '.'.
    /// * 1 <= numRows <= 1000
    /// 
    /// </summary>
    public class N0006_ZigzagConversion
    {
        public class Solution1
        {
            public string Convert(string s, int numRows)
            {
                var chars = s.ToCharArray();
                var allIndex = 0;
                var maxJump = DistanceOf(numRows);
                for (int row = 0; row < numRows; row++)
                {
                    var index = row;
                    var alter = (row != 0) && (row != numRows - 1);
                    var oddJump = DistanceOf(row + 1);
                    var evenJump = DistanceOf(numRows - row);
                    var odd = false;
                    while (index < s.Length)
                    {
                        chars[allIndex++] = s[index];
                        if (!alter)
                        {
                            index += maxJump;
                        }
                        else
                        {
                            index += odd ? oddJump : evenJump;
                            odd = !odd;
                        }
                    }
                }
                return new string(chars);
            }

            private int DistanceOf(int row)
            {
                if (row <= 2)
                    return row;
                else
                    return 2 * row - 2;
            }
        }

        public class Solution2
        {
            public string Convert(string s, int numRows)
            {
                if (numRows <= 1) return s;

                int n = s.Length;
                char[] ret = new char[n];
                int cycleLen = 2 * numRows - 2;
                int index = 0;

                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j + i < n; j += cycleLen)
                    {
                        ret[index++] = s[j + i];
                        if (i != 0 && i != numRows - 1 && j + cycleLen - i < n)
                            ret[index++] = s[j + cycleLen - i];
                    }
                }
                return new string(ret);
            }
        }
    }
}