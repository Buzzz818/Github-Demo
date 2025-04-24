/*File Name: LeetCode51.cs

*Name: Brad Caldwell

*email: caldwebf@mail.uc.edu
*Assignment Number: Final Project  
*Due Date: 4/29/2025
*Course #/Section:   001
* Semester / Year:   Spring 2025
*Brief Description of the assignment:  Create a bootstrapped webpage to showcase 4 different leetcode
*solutions 

*Brief Description of what this module does. This is the class for LeetCode51
*Citations: https://chatgpt.com/
*Anything else that's relevant: 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Github_Demo
{   
     // Solution to LeetCode51
    public class LeetCode51
    {
        /// <summary>
        /// Finds all possible placements of n queens on an n x n grid
        /// </summary>
        /// <param name="n"> the number of queens and dimmension of grid</param>
        /// <returns> all possible solutions to where no queen can attack another</returns>
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