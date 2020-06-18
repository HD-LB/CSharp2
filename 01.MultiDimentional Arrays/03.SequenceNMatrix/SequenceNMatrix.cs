//•We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//•Write a program that finds the longest sequence of equal strings in the matrix.



using System;
using System.Linq;

namespace _03.SequenceNMatrix
{
   class SequenceNMatrix
   {
      static void Main()
      {


         int n = int.Parse(Console.ReadLine());
         int m = int.Parse(Console.ReadLine());

         string[,] matrix = new string[n, m];

         //Filling the Matrix
         for (int row = 0; row < matrix.GetLength(0); row++)
         {
            string[] current = Console.ReadLine().Split(' ').ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
               matrix[row, col] = current[col];
            }
            
         }


         //for (int row = 0; row < matrix.GetLength(0); row++)
         //{
         //   for (int col = 0; col < matrix.GetLength(1); col++)
         //   {
         //      string input = Console.ReadLine();
         //      matrix[row, col] = input;
         //   }
         //}


         //Printing the Matrix
         for (int row = 0; row < matrix.GetLength(0); row++)
         {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
               Console.Write("{0, 5}", matrix[row, col]);
            }
            Console.WriteLine();
         }

         int currentElement = 0;
         int maxElement = 0;
         string maxSeq = string.Empty;

         //Horizontal
         for (int row = 0; row < matrix.GetLength(0); row++)
         {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
               if (matrix[row, col] == matrix[row, col + 1])
               {
                  currentElement++;
               }
               else
               {
                  currentElement = 1;
               }
               if (currentElement > maxElement)
               {
                  maxElement = currentElement;
                  maxSeq = matrix[row, col];
               }
            }
            currentElement = 1;
         }


         //Verical
         for (int col = 0; col < matrix.GetLength(1); col++)
         {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
               if (matrix[row, col] == matrix[row + 1, col])
               {
                  currentElement++;
               }
               else
               {
                  currentElement = 1;
               }
               if (currentElement > maxElement)
               {
                  maxElement = currentElement;
                  maxSeq = matrix[row, col];
               }
            }
            currentElement = 1;
         }


         //Diagonal
         for (int row = 0; row < matrix.GetLength(0) - 1; row++)
         {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
               if (matrix[row,col] == matrix[row + 1, col + 1])
               {
                  currentElement++;
               }
               else
               {
                  currentElement = 1;
               }
               if (currentElement > maxElement)
               {
                  maxElement = currentElement;
                  maxSeq = matrix[row, col];
               }
            }
         }

         Console.WriteLine("The longest Sequence is: ");
         for (int i = 0; i < maxElement; i++)
         {
            Console.Write(maxSeq + ", ");
         }
         

      }
   }
}
