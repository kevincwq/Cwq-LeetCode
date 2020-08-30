using NUnit.Framework;

namespace CSharpImpl.Tests
{
    public class UT_N36_ValidSudoku
    {
        static object[] TestCases =
        {
            new object[]{ new char[][] {
                new char[]{'5','3','.','.','7','.','.','.','.'},
                new char[]{'6','.','.','1','9','5','.','.','.'},
                new char[]{'.','9','8','.','.','.','.','6','.'},
                new char[]{'8','.','.','.','6','.','.','.','3'},
                new char[]{'4','.','.','8','.','3','.','.','1'},
                new char[]{'7','.','.','.','2','.','.','.','6'},
                new char[]{'.','6','.','.','.','.','2','8','.'},
                new char[]{'.','.','.','4','1','9','.','.','5'},
                new char[]{'.','.','.','.','8','.','.','7','9'}
            }, true},
            new object[]{ new char[][] {
                new char[]{'5','3','.','.','7','.','.','.','.'},
                new char[]{'6','.','.','1','9','5','.','.','.'},
                new char[]{'.','9','8','.','.','.','.','6','.'},
                new char[]{'8','.','.','.','6','.','.','.','3'},
                new char[]{'4','.','.','8','.','3','.','.','1'},
                new char[]{'7','.','.','.','2','.','.','.','6'},
                new char[]{'.','6','.','.','.','.','2','8','.'},
                new char[]{'.','.','.','4','1','9','.','.','5'},
                new char[]{'.','.','.','.','8','.','5','7','9'}
            }, false},
        };

        [TestCaseSource(nameof(TestCases))]
        public void Solution1(char[][] board, bool ans)
        {
            var so = new N36_ValidSudoku.Solution1();
            var valid = so.IsValidSudoku(board);
            Assert.AreEqual(ans, valid);
        }
    }
}