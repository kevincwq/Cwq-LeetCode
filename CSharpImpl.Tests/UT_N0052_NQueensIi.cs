using NUnit.Framework;
using System.Collections.Generic;

namespace CSharpImpl.Tests
{
    public class UT_N0052_NQueensIi
    {
        static object[] TestCases =
        {
            new object[]{ 1, new List<IList<string>> { new List<string> { "Q" } } },
            new object[]{ 2, new List<IList<string>> { } },
            new object[]{ 3, new List<IList<string>> { } },
            new object[]{ 4,
                new List<IList<string>> {
                    new List<string>{ ".Q..", "...Q", "Q...", "..Q." },
                    new List<string>{ "..Q.", "Q...", "...Q", ".Q.." }
                }
            },
            new object[]{ 5,
                new List<IList<string>>{
                    new List<string>{"Q....","..Q..","....Q",".Q...","...Q."},
                    new List<string>{"Q....","...Q.",".Q...","....Q","..Q.."},
                    new List<string>{".Q...","...Q.","Q....","..Q..","....Q"},
                    new List<string>{".Q...","....Q","..Q..","Q....","...Q."},
                    new List<string>{"..Q..","Q....","...Q.",".Q...","....Q"},
                    new List<string>{"..Q..","....Q",".Q...","...Q.","Q...."},
                    new List<string>{"...Q.","Q....","..Q..","....Q",".Q..."},
                    new List<string>{"...Q.",".Q...","....Q","..Q..","Q...."},
                    new List<string>{"....Q",".Q...","...Q.","Q....","..Q.."},
                    new List<string>{"....Q","..Q..","Q....","...Q.",".Q..."}
                }
            },
            new object[]{ 6,
                new List<IList<string>>{
                    new List<string>{".Q....","...Q..",".....Q","Q.....","..Q...","....Q."},
                    new List<string>{"..Q...",".....Q",".Q....","....Q.","Q.....","...Q.."},
                    new List<string>{"...Q..","Q.....","....Q.",".Q....",".....Q","..Q..."},
                    new List<string>{"....Q.","..Q...","Q.....",".....Q","...Q..",".Q...."}
                }
            }
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(int input, IList<IList<string>> expected)
        {
            var so = new N0052_NQueensIi.Solution1();
            var ans = so.TotalNQueens(input);
            Assert.AreEqual(expected.Count, ans);
        }
    }
}