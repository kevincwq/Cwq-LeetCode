using NUnit.Framework;
using System.Collections.Generic;

namespace CSharpImpl.Tests
{
    public class UT_N0051_NQueens
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
            var so = new N0051_NQueens.Solution1();
            var ans = so.SolveNQueens(input);
            TestHelper.AreEqual(expected, ans);
        }
    }
}