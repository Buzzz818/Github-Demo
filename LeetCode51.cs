using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Github_Demo
{
    public class LeetCode51
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            var result = new List<IList<string>>();
            var board = new char[n][];

            // Initialize the board with empty spots
            for (int i = 0; i < n; i++)
            {
                board[i] = new char[n];
                for (int j = 0; j < n; j++)
                {
                    board[i][j] = '.';
                }
            }

            // Backtrack function to solve the problem
            Solve(board, 0, n, result);

            return result;
        }

        private void Solve(char[][] board, int row, int n, List<IList<string>> result)
        {
            if (row == n)
            {
                // If we've placed queens in all rows, add the board to result
                var solution = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    solution.Add(new string(board[i]));
                }
                result.Add(solution);
                return;
            }

            for (int col = 0; col < n; col++)
            {
                if (IsSafe(board, row, col, n))
                {
                    board[row][col] = 'Q';  // Place the queen
                    Solve(board, row + 1, n, result);  // Recurse to next row
                    board[row][col] = '.';  // Backtrack
                }
            }
        }

        private bool IsSafe(char[][] board, int row, int col, int n)
        {
            // Check the column
            for (int i = 0; i < row; i++)
            {
                if (board[i][col] == 'Q')
                {
                    return false;
                }
            }

            // Check the diagonal (upper-left to lower-right)
            for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i][j] == 'Q')
                {
                    return false;
                }
            }

            // Check the diagonal (upper-right to lower-left)
            for (int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++)
            {
                if (board[i][j] == 'Q')
                {
                    return false;
                }
            }

            return true;
        }
    }
}