using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N0037_SodoluSolver
    {
        static readonly object[] S1_TestCases1 =
        {
            new object[]{
                new char[][] {
                    new char[]{'5','3','.','.','7','.','.','.','.'},
                    new char[]{'6','.','.','1','9','5','.','.','.'},
                    new char[]{'.','9','8','.','.','.','.','6','.'},
                    new char[]{'8','.','.','.','6','.','.','.','3'},
                    new char[]{'4','.','.','8','.','3','.','.','1'},
                    new char[]{'7','.','.','.','2','.','.','.','6'},
                    new char[]{'.','6','.','.','.','.','2','8','.'},
                    new char[]{'.','.','.','4','1','9','.','.','5'},
                    new char[]{'.','.','.','.','8','.','.','7','9'}
                },
                new char[][] {
                    new char[]{'5','3','4','6','7','8','9','1','2'},
                    new char[]{'6','7','2','1','9','5','3','4','8'},
                    new char[]{'1','9','8','3','4','2','5','6','7'},
                    new char[]{'8','5','9','7','6','1','4','2','3'},
                    new char[]{'4','2','6','8','5','3','7','9','1'},
                    new char[]{'7','1','3','9','2','4','8','5','6'},
                    new char[]{'9','6','1','5','3','7','2','8','4'},
                    new char[]{'2','8','7','4','1','9','6','3','5'},
                    new char[]{'3','4','5','2','8','6','1','7','9'}
                }
            }
        };

        static readonly object[] S1_TestCases2 =
        {
            new object[]{
                new char[][] {
                    new char[]{'.','.','9','7','4','8','.','.','.'},
                    new char[]{'7','.','.','.','.','.','.','.','.'},
                    new char[]{'.','2','.','1','.','9','.','.','.'},
                    new char[]{'.','.','7','.','.','.','2','4','.'},
                    new char[]{'.','6','4','.','1','.','5','9','.'},
                    new char[]{'.','9','8','.','.','.','3','.','.'},
                    new char[]{'.','.','.','8','.','3','.','2','.'},
                    new char[]{'.','.','.','.','.','.','.','.','6'},
                    new char[]{'.','.','.','2','7','5','9','.','.'}
                },
                new char[][] {
                    new char[]{'5','1','9','7','4','8','6','3','2'},
                    new char[]{'7','8','3','6','5','2','4','1','9'},
                    new char[]{'4','2','6','1','3','9','8','7','5'},
                    new char[]{'3','5','7','9','8','6','2','4','1'},
                    new char[]{'2','6','4','3','1','7','5','9','8'},
                    new char[]{'1','9','8','5','2','4','3','6','7'},
                    new char[]{'9','7','5','8','6','3','1','2','4'},
                    new char[]{'8','3','2','4','9','1','7','5','6'},
                    new char[]{'6','4','1','2','7','5','9','8','3'}
                }
            }
        };

        static readonly object[] S1_TestCases3 =
{
            new object[]{
                new char[][] {
                    new char[]{'.','1','.','.','4','8','6','.','2'},
                    new char[]{'.','8','.','6','.','2','4','1','.'},
                    new char[]{'4','2','6','1','.','.','8','.','.'},
                    new char[]{'.','.','.','.','8','6','2','4','1'},
                    new char[]{'2','6','4','.','1','.','.','.','8'},
                    new char[]{'1','.','8','.','2','4','.','6','.'},
                    new char[]{'.','.','.','8','6','.','1','2','4'},
                    new char[]{'8','.','2','4','.','1','.','.','6'},
                    new char[]{'6','4','1','2','.','.','.','8','.'}
                },
                new char[][] {
                    new char[]{'3','1','5','7','4','8','6','9','2'},
                    new char[]{'7','8','9','6','3','2','4','1','5'},
                    new char[]{'4','2','6','1','5','9','8','3','7'},
                    new char[]{'5','3','7','9','8','6','2','4','1'},
                    new char[]{'2','6','4','3','1','7','9','5','8'},
                    new char[]{'1','9','8','5','2','4','7','6','3'},
                    new char[]{'9','7','3','8','6','5','1','2','4'},
                    new char[]{'8','5','2','4','9','1','3','7','6'},
                    new char[]{'6','4','1','2','7','3','5','8','9'}
                }
            }
        };

        [TestCaseSource(nameof(S1_TestCases1))]
        public void Solution1_1(char[][] board, char[][] exptected)
        {
            var so = new N0037_SodokuSolver.Solution1();
            so.SolveSudoku(board);
            Assert.IsTrue(TestHelper.AreEqual(board, exptected));
        }

        [TestCaseSource(nameof(S1_TestCases2))]
        public void Solution1_2(char[][] board, char[][] exptected)
        {
            var so = new N0037_SodokuSolver.Solution1();
            so.SolveSudoku(board);
            Assert.IsTrue(TestHelper.AreEqual(board, exptected));
        }

        [TestCaseSource(nameof(S1_TestCases3))]
        public void Solution1_3(char[][] board, char[][] exptected)
        {
            var so = new N0037_SodokuSolver.Solution1();
            so.SolveSudoku(board);
            Assert.IsTrue(TestHelper.AreEqual(board, exptected));
        }

        static readonly object[] S2_TestCases1 =
 {
            new object[]{
                new char[][] {
                    new char[]{'5','3','.','.','7','.','.','.','.'},
                    new char[]{'6','.','.','1','9','5','.','.','.'},
                    new char[]{'.','9','8','.','.','.','.','6','.'},
                    new char[]{'8','.','.','.','6','.','.','.','3'},
                    new char[]{'4','.','.','8','.','3','.','.','1'},
                    new char[]{'7','.','.','.','2','.','.','.','6'},
                    new char[]{'.','6','.','.','.','.','2','8','.'},
                    new char[]{'.','.','.','4','1','9','.','.','5'},
                    new char[]{'.','.','.','.','8','.','.','7','9'}
                },
                new char[][] {
                    new char[]{'5','3','4','6','7','8','9','1','2'},
                    new char[]{'6','7','2','1','9','5','3','4','8'},
                    new char[]{'1','9','8','3','4','2','5','6','7'},
                    new char[]{'8','5','9','7','6','1','4','2','3'},
                    new char[]{'4','2','6','8','5','3','7','9','1'},
                    new char[]{'7','1','3','9','2','4','8','5','6'},
                    new char[]{'9','6','1','5','3','7','2','8','4'},
                    new char[]{'2','8','7','4','1','9','6','3','5'},
                    new char[]{'3','4','5','2','8','6','1','7','9'}
                }
            }
        };

        static readonly object[] S2_TestCases2 =
        {
            new object[]{
                new char[][] {
                    new char[]{'.','.','9','7','4','8','.','.','.'},
                    new char[]{'7','.','.','.','.','.','.','.','.'},
                    new char[]{'.','2','.','1','.','9','.','.','.'},
                    new char[]{'.','.','7','.','.','.','2','4','.'},
                    new char[]{'.','6','4','.','1','.','5','9','.'},
                    new char[]{'.','9','8','.','.','.','3','.','.'},
                    new char[]{'.','.','.','8','.','3','.','2','.'},
                    new char[]{'.','.','.','.','.','.','.','.','6'},
                    new char[]{'.','.','.','2','7','5','9','.','.'}
                },
                new char[][] {
                    new char[]{'5','1','9','7','4','8','6','3','2'},
                    new char[]{'7','8','3','6','5','2','4','1','9'},
                    new char[]{'4','2','6','1','3','9','8','7','5'},
                    new char[]{'3','5','7','9','8','6','2','4','1'},
                    new char[]{'2','6','4','3','1','7','5','9','8'},
                    new char[]{'1','9','8','5','2','4','3','6','7'},
                    new char[]{'9','7','5','8','6','3','1','2','4'},
                    new char[]{'8','3','2','4','9','1','7','5','6'},
                    new char[]{'6','4','1','2','7','5','9','8','3'}
                }
            }
        };

        static readonly object[] S2_TestCases3 =
{
            new object[]{
                new char[][] {
                    new char[]{'.','1','.','.','4','8','6','.','2'},
                    new char[]{'.','8','.','6','.','2','4','1','.'},
                    new char[]{'4','2','6','1','.','.','8','.','.'},
                    new char[]{'.','.','.','.','8','6','2','4','1'},
                    new char[]{'2','6','4','.','1','.','.','.','8'},
                    new char[]{'1','.','8','.','2','4','.','6','.'},
                    new char[]{'.','.','.','8','6','.','1','2','4'},
                    new char[]{'8','.','2','4','.','1','.','.','6'},
                    new char[]{'6','4','1','2','.','.','.','8','.'}
                },
                new char[][] {
                    new char[]{'3','1','5','7','4','8','6','9','2'},
                    new char[]{'7','8','9','6','3','2','4','1','5'},
                    new char[]{'4','2','6','1','5','9','8','3','7'},
                    new char[]{'5','3','7','9','8','6','2','4','1'},
                    new char[]{'2','6','4','3','1','7','9','5','8'},
                    new char[]{'1','9','8','5','2','4','7','6','3'},
                    new char[]{'9','7','3','8','6','5','1','2','4'},
                    new char[]{'8','5','2','4','9','1','3','7','6'},
                    new char[]{'6','4','1','2','7','3','5','8','9'}
                }
            }
        };


        [TestCaseSource(nameof(S2_TestCases1))]
        public void Solution2_1(char[][] board, char[][] exptected)
        {
            var so = new N0037_SodokuSolver.Solution2();
            so.SolveSudoku(board);
            Assert.IsTrue(TestHelper.AreEqual(board, exptected));
        }

        [TestCaseSource(nameof(S2_TestCases2))]
        public void Solution2_2(char[][] board, char[][] exptected)
        {
            var so = new N0037_SodokuSolver.Solution2();
            so.SolveSudoku(board);
            Assert.IsTrue(TestHelper.AreEqual(board, exptected));
        }

        [TestCaseSource(nameof(S2_TestCases3))]
        public void Solution2_3(char[][] board, char[][] exptected)
        {
            var so = new N0037_SodokuSolver.Solution2();
            so.SolveSudoku(board);
            Assert.IsTrue(TestHelper.AreEqual(board, exptected));
        }
    }
}