using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace CSharpImpl.Tests
{
    public class UT_N0702_SearchInASortedArrayOfUnknownSize 
    {
        static object[] TestCases =
        {
            new object[]{ new int[] {}, new int[] { } },
        };

        // [TestCaseSource(nameof(TestCases))]
        public void Solution1(int[] input, int[] expected)
        {
            throw new NotImplementedException();
        }
    }
}