﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Serialization;

namespace CSharpImpl
{
    public class N37_SodokuSolver
    {
        // 37. Sudoku Solver
        // https://leetcode.com/problems/sudoku-solver/

        //Write a program to solve a Sudoku puzzle by filling the empty cells.
        //A sudoku solution must satisfy all of the following rules:
        //Each of the digits 1-9 must occur exactly once in each row.
        //Each of the digits 1-9 must occur exactly once in each column.
        //Each of the the digits 1-9 must occur exactly once in each of the 9 3x3 sub-boxes of the grid.

        //Example 1:
        //Input:
        //[
        //  ["5","3",".",".","7",".",".",".","."],
        //  ["6",".",".","1","9","5",".",".","."],
        //  [".","9","8",".",".",".",".","6","."],
        //  ["8",".",".",".","6",".",".",".","3"],
        //  ["4",".",".","8",".","3",".",".","1"],
        //  ["7",".",".",".","2",".",".",".","6"],
        //  [".","6",".",".",".",".","2","8","."],
        //  [".",".",".","4","1","9",".",".","5"],
        //  [".",".",".",".","8",".",".","7","9"]
        //]
        //Output: true

        //Note:
        //The given board contain only digits 1-9 and the character '.'.
        //You may assume that the given Sudoku puzzle will have a single unique solution.
        //The given board size is always 9x9.

        public class Solution1
        {
            int Len = 9, Sqrt = 3;
            char[][] board;
            bool[][] rows, cols, grids;
            int[] counts;

            public void SolveSudoku(char[][] board)
            {
                Len = board.Length;
                Sqrt = (int)Math.Sqrt(Len);
                this.board = board;
                rows = CreateArray<bool>(Len);
                cols = CreateArray<bool>(Len);
                grids = CreateArray<bool>(Len);
                counts = Enumerable.Repeat(Len, Len).ToArray();

                for (int i = 0; i < Len; i++)
                {
                    for (int j = 0; j < Len; j++)
                    {
                        var ch = board[i][j];
                        if (ch != '.')
                        {
                            var num = ch - '1';
                            rows[num][i] = true;
                            cols[num][j] = true;
                            grids[num][(i / Sqrt) * Sqrt + j / Sqrt] = true;
                            counts[num]--;
                        }
                    }
                }

                // fill the certain cells first
                while (counts.Any(c => c > 0) && FillCertainCells() > 0) ;

                // back-tracking the uncertain cells
                FillUncertainCells();

                DebugHelper.Print(board);
            }

            private T[][] CreateArray<T>(int len)
            {
                var array = new T[len][];
                for (int i = 0; i < len; i++)
                {
                    array[i] = new T[len];
                }
                return array;
            }

            private bool FillUncertainCells()
            {
                if (counts.All(c => c == 0))
                {
                    return true;
                }
                var num = Array.IndexOf(counts, counts.Where(c => c > 0).Max());
                var index = Array.IndexOf(grids[num], false);
                var positions = GetPotentialPositions(num, index);
                if (positions.Count == 0)
                    return false;
                foreach (var (row, col) in positions)
                {
                    FillACell(num, index, row, col);
                    if (FillUncertainCells())
                    {
                        return true;
                    }
                    UnFillACell(num, index, row, col);
                }

                return false;
            }

            private int FillCertainCells()
            {
                var fill = 0;
                foreach (var it in counts.Where(c => c > 0).Select((c, s) => (c, s)).OrderByDescending(kv => kv.c).ToArray())
                {
                    var num = it.s;
                    for (int i = 0; i < Len; i++)
                    {
                        if (!grids[num][i] && HasOnlyOnePotentialPosition(num, i, out int r, out int c))
                        {
                            FillACell(num, i, r, c);
                            fill++;
                        }
                    }
                }

                return fill;
            }

            private void FillACell(int num, int i, int r, int c)
            {
                grids[num][i] = true;
                rows[num][r] = true;
                cols[num][c] = true;
                board[r][c] = (char)('1' + num);
                counts[num]--;
            }

            private void UnFillACell(int num, int i, int r, int c)
            {
                grids[num][i] = false;
                rows[num][r] = false;
                cols[num][c] = false;
                board[r][c] = '.';
                counts[num]++;
            }

            private bool HasOnlyOnePotentialPosition(int num, int index, out int row, out int col)
            {
                var r_start = index / Sqrt * Sqrt;
                var c_start = index % Sqrt * Sqrt;
                row = -1;
                col = -1;

                for (int r = r_start; r < r_start + Sqrt; r++)
                {
                    for (int c = c_start; c < c_start + Sqrt; c++)
                    {
                        if (!rows[num][r] && !cols[num][c] && board[r][c] == '.')
                        {
                            if (row != -1)
                                return false;
                            row = r;
                            col = c;
                        }
                    }
                }
                return row != -1;
            }

            private List<(int row, int col)> GetPotentialPositions(int num, int index)
            {
                var result = new List<(int, int)>();
                var r_start = index / Sqrt * Sqrt;
                var c_start = index % Sqrt * Sqrt;
                for (int r = r_start; r < r_start + Sqrt; r++)
                {
                    for (int c = c_start; c < c_start + Sqrt; c++)
                    {
                        if (!rows[num][r] && !cols[num][c] && board[r][c] == '.')
                        {
                            result.Add((r, c));
                        }
                    }
                }
                return result;
            }
        }


        public class Solution2
        {
            int Len = 9, Sqrt = 3, Total = 9 * 9;

            // back-tracking
            public void SolveSudoku(char[][] board)
            {
                Len = board.Length;
                Sqrt = (int)Math.Sqrt(Len);
                Total = Len * Len;

                if (!FillCell(board, 0))
                    throw new ApplicationException("Could not find any solution!");
            }

            private bool FillCell(char[][] board, int i)
            {
                if (i == Total)
                {
                    return true;
                }

                var r = i / Len;
                var c = i % Len;
                if (board[r][c] == '.')
                {
                    for (int k = 0; k < 9; k++)
                    {
                        var v = (char)('1' + k);
                        if (IsOk(board, r, c, v))
                        {
                            board[r][c] = v;
                            if (FillCell(board, i + 1))
                                return true;
                            else
                                board[r][c] = '.';
                        }
                    }
                    return false;
                }
                else
                {
                    return FillCell(board, i + 1);
                }
            }

            private bool IsOk(char[][] board, int r, int c, char v)
            {
                var g_r = r / Sqrt * Sqrt;
                var g_c = c / Sqrt * Sqrt;
                for (int i = 0; i < Len; i++)
                {
                    if (board[r][i] == v || board[i][c] == v || board[g_r + i / Sqrt][g_c + i % Sqrt] == v)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}