using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0049_GroupAnagrams
    {
        static object[] TestCases =
        {
            new object[]{ new string[] { "eat", "tea", "tan", "ate", "nat", "bat" },
                new List<IList<string>> () {
                    new List<string>{ "bat" },
                    new List<string>{ "nat", "tan" },
                    new List<string>{ "ate", "eat", "tea" }
                }
             },
            new object[]{ new string[] { "a" },
                new List<IList<string>> () {
                    new List<string>{ "a" }
                }
             },
            new object[]{ new string[] { "" },
                new List<IList<string>> () {
                    new List<string>{ "" }
                }
             }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(string[] input, IList<IList<string>> expected)
        {
            var so = new N0049_GroupAnagrams.Solution1();
            var ans = so.GroupAnagrams(input);
            TestHelper.AreEqual(expected, ans);
        }
    }
}