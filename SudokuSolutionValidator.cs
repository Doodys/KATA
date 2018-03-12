using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolutionValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] Sudoku = new int[][]
            {
              new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
              new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
              new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
              new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
              new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
              new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
              new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
              new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
              new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
            }; //true
            Console.WriteLine(ValidateSolution(Sudoku));
        }
        public static bool ValidateSolution(int[][] board)
        {
            int x = 0, y = 0, z = 3, v = 3;

            for (int k = 0; k < 9; k++)
            {
                for (int i = 0; i < 9; i++)
                    for (int j = 1; j < 10; j++)
                        if (board[k][i] == j) { x++; y += board[k][i]; }
                        else continue;
                if (x == 9 && y == 45) { x -= 9; y -= 45; continue; }
                else { return false; }
            }

            for (int k = 0; k < 9; k++)
            {
                for (int i = 0; i < 9; i++)
                    for (int j = 1; j < 10; j++)
                        if (board[i][k] == j) { x++; y += board[i][k]; }
                        else continue;
                if (x == 9 && y == 45) { x -= 9; y -= 45; continue; }
                else { return false; }
            }

            for (int k = 0; k < 9; k++)
            {
                if (k == 3 || k == 6) { z += 3; v += 3; }
                for (int i = z - 3; i < z; i++)
                    for (int j = v - 3; j < v; j++)
                        for (int l = 1; l < 10; l++)
                            if (board[i][j] == l) { x++; y += board[i][j]; }
                if (x == 9 && y == 45) { x -= 9; y -= 45;}
                else { return false; }
            }
            return true;
        }
    }
}
