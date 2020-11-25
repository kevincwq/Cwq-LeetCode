using System.Linq;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/n-queens-ii/
    /// 
    /// The n-queens puzzle is the problem of placing n queens on an n×n chessboard such that no two queens attack each other.
    /// <https://assets.leetcode.com/uploads/2018/10/12/8-queens.png>
    /// Given an integer n, return the number of distinct solutions to the n-queens puzzle.
    /// 
    /// Example:
    /// Input: 4
    /// Output: 2
    /// 
    /// Explanation: There are two distinct solutions to the 4-queens puzzle as shown below. 
    /// [[".Q..", "...Q", "Q...", "..Q."], // Solution 1
    /// ["..Q.", "Q...", "...Q", ".Q.."]]  // Solution 2
    /// 
    /// </summary>
    public class N0052_NQueensIi
    {
        public class Solution1
        {
            public int TotalNQueens(int n)
            {
                int count = 0;
                var board = NewBoard(n);
                Place(board, n, 0, ref count);
                return count;
            }

            private char[][] NewBoard(int n)
            {
                var board = new char[n][];
                for (int i = 0; i < n; i++)
                {
                    board[i] = new char[n];
                }
                return board;
            }

            private char[][] CloneBoard(char[][] board)
            {
                return board.Select(v => (char[])v.Clone()).ToArray();
            }

            private void FillQCells(char[][] board, int n, int i, int j)
            {
                board[i][j] = 'Q';
                int k = 0;
                while (k < n)
                {
                    if (board[k][j] == default(char))
                        board[k][j] = '.';
                    if (board[i][k] == default(char))
                        board[i][k] = '.';
                    k++;
                }
                k = i; int l = j;
                while (--k >= 0 && --l >= 0)
                {
                    if (board[k][l] == default(char))
                        board[k][l] = '.';
                }
                k = i; l = j;
                while (--k >= 0 && ++l < n)
                {
                    if (board[k][l] == default(char))
                        board[k][l] = '.';
                }
                k = i; l = j;
                while (++k < n && --l >= 0)
                {
                    if (board[k][l] == default(char))
                        board[k][l] = '.';
                }
                k = i; l = j;
                while (++k < n && ++l < n)
                {
                    if (board[k][l] == default(char))
                        board[k][l] = '.';
                }
            }

            /// <summary>
            /// Place queen at pos
            /// </summary>
            private void Place(char[][] board, int n, int q_index, ref int count)
            {
                if (q_index == n)
                {
                    count++;
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (board[q_index][i] == default(char))
                        {
                            var clone = CloneBoard(board);
                            FillQCells(clone, n, q_index, i);
                            Place(clone, n, q_index + 1, ref count);
                        }
                    }
                }
            }
        }
    }
}