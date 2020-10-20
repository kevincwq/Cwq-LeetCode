using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    /// 
    /// Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.
    /// A mapping of digit to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.
    /// <https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Telephone-keypad2.svg/200px-Telephone-keypad2.svg.png>
    /// 
    /// Example 1:
    /// Input: digits = "23"
    /// Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
    /// 
    /// Example 2:
    /// Input: digits = ""
    /// Output: []
    /// 
    /// Example 3:
    /// Input: digits = "2"
    /// Output: ["a","b","c"]
    /// 
    /// 
    /// Constraints:
    /// * 0 <= digits.length <= 4
    /// * digits[i] is a digit in the range ['2', '9'].
    /// 
    /// </summary>
    public class N0017_LetterCombinationsOfAPhoneNumber
    {
        public class Solution1
        {
            static char[][] Map = new char[][] {
                    new []{'a', 'b', 'c'}, // 2
                    new []{'d', 'e', 'f'}, // 3
                    new []{'g', 'h', 'i'}, // 4
                    new []{'j', 'k', 'l'}, // 5
                    new []{'m', 'n', 'o'}, // 6
                    new []{'p', 'q', 'r', 's'}, // 7
                    new []{'t', 'u', 'v'}, // 8
                    new []{'w', 'x', 'y', 'z'}, // 9
                };
            public IList<string> LetterCombinations(string digits)
            {
                var list = new List<string>();
                if (digits.Length > 0)
                {
                    var chars = new char[digits.Length];
                    var c = 1;
                    foreach (var digit in digits)
                    {
                        c *= Map[digit - '2'].Length;
                    }
                    for (int i = 0; i < c; i++)
                    {
                        var index = i;
                        for (int j = digits.Length - 1; j > -1; j--)
                        {
                            var key = Map[digits[j] - '2'];
                            chars[j] = key[index % key.Length];
                            index /= key.Length;
                        }
                        list.Add(new string(chars));
                    }
                }
                return list;
            }
        }

        public class Solution2
        {
            static char[][] Map = new char[][] {
                    new []{'a', 'b', 'c'}, // 2
                    new []{'d', 'e', 'f'}, // 3
                    new []{'g', 'h', 'i'}, // 4
                    new []{'j', 'k', 'l'}, // 5
                    new []{'m', 'n', 'o'}, // 6
                    new []{'p', 'q', 'r', 's'}, // 7
                    new []{'t', 'u', 'v'}, // 8
                    new []{'w', 'x', 'y', 'z'}, // 9
                };
            public IList<string> LetterCombinations(string digits)
            {
                throw new NotImplementedException();
            }
        }
    }
}