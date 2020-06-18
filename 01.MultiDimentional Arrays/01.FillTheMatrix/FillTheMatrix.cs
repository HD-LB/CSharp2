//•Write a program that fills and prints a matrix of size (n, n) as shown below:

//Example for n=4:

//a)
//1 5 9 13 
//2 6 10 14 
//3 7 11 15 
//4 8 12 16 

//b) 
//1 8 9 16 
//2 7 10 15 
//3 6 11 14 
//4 5 12 13

//c) 
//7 11 14 16 
//4 8 12 15 
//2 5 9 13 
//1 3 6 10 

//d) 
//1 12 11 10 
//2 13 16 9 
//3 14 15 8 
//4 5 6 7 



using System;


namespace _01.FillTheMatrix
{
   class FillTheMatrix
   {
      static void Main()
      {
         int n = int.Parse(Console.ReadLine());
         int[,] spiral = new int[n, n];


         ////Condition a)
         //int counter = 1;
         //for (int col = 0; col < spiral.GetLength(1); col++)
         //{
         //   for (int row = 0; row < spiral.GetLength(0); row++)
         //   {
         //      spiral[row, col] = counter;
         //      counter++;

         //   }
         //}
         //MatrixPrint(spiral);

         //Console.WriteLine();
         //Console.WriteLine();



         ////Condition b)
         //counter = 1; //reset the value ot the variable to its initial state
         //for (int col = 0; col < spiral.GetLength(1); col++)
         //{
         //   if (col % 2 == 0)
         //   {
         //      for (int row = 0; row < spiral.GetLength(0); row++)
         //      {
         //         spiral[row, col] = counter;
         //         counter++;
         //      }
         //   }
         //   else
         //   {
         //      for (int row = spiral.GetLength(0) - 1; row >= 0; row--)
         //      {
         //         spiral[row, col] = counter;
         //         counter++;
         //      }
         //   }
         //}
         //MatrixPrint(spiral);




         ////Condition c)
         //counter = 1; //reset the value ot the variable to its initial state


         //Condition d)
         
         string direction = "right";

         int currentRow = 0;
         int currentCol = 0;

         for (int i = 1; i <= n * n; i++) //the spiral starts from 1, n * n to fill the whole matrix
         {
            if (direction == "right" && (currentCol >= n || spiral[currentRow, currentCol] != 0))
            {
               currentCol--;
               currentRow++;
               direction = "down";
            }
            else if (direction == "down" && (currentRow >= n || spiral[currentRow, currentCol] != 0))
            {
               currentCol--;
               currentRow--;
               direction = "left";
            }
            else if (direction == "left" && (currentCol < 0 || spiral[currentRow, currentCol] != 0))
            {
               currentRow--;
               currentCol++;
               direction = "up";
            }
            else if (direction == "up" && (currentRow < 0 || spiral[currentRow, currentCol] != 0))
            {
               currentRow++;
               currentCol++;
               direction = "right";
            }





            spiral[currentRow, currentCol] = i;
            if (direction == "right")
            {
               currentCol++;
            }
            else if (direction == "down")
            {
               currentRow++;
            }
            else if (direction == "left")
            {
               currentCol--;
            }
            else if (direction == "up")
            {
               currentRow--;
            }
         }


         MatrixPrint(spiral);

      }


      //Output
      private static void MatrixPrint(int[,] spiral)
      {
         for (int row = 0; row < spiral.GetLength(0); row++)
         {
            for (int col = 0; col < spiral.GetLength(1); col++)
            {
               Console.Write("{0, 4}", spiral[row, col]);
            }
            Console.WriteLine();

         }

      }
   }
}
