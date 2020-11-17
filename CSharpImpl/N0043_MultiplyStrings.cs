using System;
using System.Text;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/multiply-strings/
    /// 
    /// Given two non-negative integers num1 and num2 represented as strings, return the product of num1 and num2, also represented as a string.
    /// Example 1:
    /// Input: num1 = "2", num2 = "3"
    /// Output: "6"
    /// 
    /// Example 2:
    /// Input: num1 = "123", num2 = "456"
    /// Output: "56088"
    /// 
    /// Constraints:
    /// 1 <= num1.length, num2.length <= 200
    /// num1 and num2 consist of digits only.
    /// Both num1 and num2 do not contain any leading zero, except the number 0 itself.
    /// 
    /// Note:
    /// 1. The length of both num1 and num2 is < 110.
    /// 2. Both num1 and num2 contain only digits 0-9.
    /// 3. Both num1 and num2 do not contain any leading zero, except the number 0 itself.
    /// 4. You must not use any built-in BigInteger library or convert the inputs to integer directly.
    /// 
    /// </summary>
    public class N0043_MultiplyStrings
    {
        public class Solution1
        {
            public string Multiply(string num1, string num2)
            {
                string shorter = num1, longer = num2;
                if (num1.Length > num2.Length)
                {
                    shorter = num2;
                    longer = num1;
                }
                longer = Reverse(longer);
                shorter = Reverse(shorter);

                var result = "";
                for (int i = 0; i < shorter.Length; i++)
                {
                    var product = new string('0', i) + Multiply(longer, shorter[i]);
                    result = Add(result, product);
                }

                return Reverse(result);
            }

            private string Reverse(string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }

            /// <summary>
            /// The num string is reversed.
            /// </summary>
            private string Multiply(string num, char digit)
            {
                if (digit == '0')
                    return "0";
                else if (digit == '1')
                    return num;
                else
                {
                    var sb = new StringBuilder();
                    var carry = 0;
                    var multiplier = digit - '0';
                    for (int i = 0; i < num.Length; i++)
                    {
                        var product = (num[i] - '0') * multiplier + carry;
                        sb.Append((char)(product % 10 + '0'));
                        carry = product / 10;
                    }
                    if (carry > 0)
                    {
                        sb.Append((char)(carry + '0'));
                    }
                    return sb.ToString();
                }
            }

            /// <summary>
            /// The num strings are reversed.
            /// </summary>
            private string Add(string num1, string num2)
            {
                if (num1.Length == 0)
                    return num2;
                if (num2.Length == 0)
                    return num1;

                var sb = new StringBuilder();
                var len = Math.Max(num1.Length, num2.Length);
                var carry = 0;
                for (int i = 0; i < len; i++)
                {
                    var sum = (i < num1.Length ? (num1[i] - '0') : 0) + (i < num2.Length ? (num2[i] - '0') : 0) + carry;
                    sb.Append((char)(sum % 10 + '0'));
                    carry = sum > 9 ? 1 : 0;
                }
                if (carry > 0)
                {
                    sb.Append((char)(carry + '0'));
                }
                return sb.ToString();
            }
        }
    }
}