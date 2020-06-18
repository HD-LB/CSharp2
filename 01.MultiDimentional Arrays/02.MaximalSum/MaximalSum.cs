//•Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

namespace _02.MaximalSum
{
   class MaximalSum
   {
      static void Main()
      {
         //int rows = int.Parse(Console.ReadLine());
         //int cols = int.Parse(Console.ReadLine());
         //int[,] matrix = new int[rows, cols];

         ////Filling the matrix
         //for (int row = 0; row < matrix.GetLength(0); row++)
         //{
         //   for (int col = 0; col < matrix.GetLength(1); col++)
         //   {
         //      Console.Write("{0, 4}", matrix[row,col]);
         //      matrix[row, col] = int.Parse(Console.ReadLine());
         //   }

         //}

         int[,] matrix =
         {
            {7, 1, 3, 3, 2, 1 },
            {1, 3, 4, 8, 5, 6 },
            {4, 6, 7, 9, 1, 0 }

         };

         int bestSum = int.MinValue;
         int bestRow = 0;
         int bestCol = 0;

         for (int row = 0; row < matrix.GetLength(0) - 2; row++)
         {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
               int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                         matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                         matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

               if (bestSum < sum)
               {
                  bestSum = sum;
                  bestRow = row;
                  bestCol = col;
               }               
            }  
         }
         Console.WriteLine(bestSum);
         Console.WriteLine(matrix[bestRow, bestCol]+ " " + matrix[bestRow, bestCol + 1]+ " " + matrix[bestRow, bestCol + 2]);
         Console.WriteLine(matrix[bestRow + 1, bestCol] + " " + matrix[bestRow + 1, bestCol + 1] + " " + matrix[bestRow + 1, bestCol + 2]);
         Console.WriteLine(matrix[bestRow + 2, bestCol] + " " + matrix[bestRow + 2, bestCol + 1] + " " + matrix[bestRow + 2, bestCol + 2]);






         ////Printing
         //for (int row = 0; row < matrix.GetLength(0); row++)
         //{
         //   for (int col = 0; col < matrix.GetLength(1); col++)
         //   {
         //      Console.Write(matrix[rows, cols]);
         //   }
         //   Console.WriteLine();

         //}

      }
   }
}
