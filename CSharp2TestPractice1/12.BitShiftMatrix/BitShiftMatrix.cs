//http://my.telerikacademy.com/Courses/Courses/Details/331

//http://bgcoder.com/Contests/223/CSharp-Part-2-2015-2016-6-March-2015-Evening

//You are given rectangular matrix.The matrix is filled with numbers that are power of 2, as follows:
//•	The bottom left corner holds the value 1
//•	The next cell above holds value of 2, the next cell above holds of 4, etc…
//•	The second cell the bottom row holds a value of 2, the cell next to it holds a value of 4
//You have a pawn on the field.The pawn can only move to the cells that directly above, below it or right/left of it.We have four directions UP, DOWN, LEFT, RIGHT.
//Given that initially the pawn starts at the bottom left corner and a list of cells that the pawn must reach calculate the sum of the cells that the pawn has to go through.
//The value of each cell is calculated only once, i.e. if the pawn visits the same cell more than once, its value is added to the result only the first time (the value is collected).
//The top row is at position 0, the bottommost row is at position ROWS – 1.
//The pawn goes from one cell to the other, following the rules:
//•	First go to the target column
//•	Second go to the target row
//Example:

//The pawn collects values: 1, 2, 4, 8, 16, 32, 16, 8, 4, 8, 16, 32, 64, 128, 256 and 512. Their sum is 1107.
//Input
//The input data is given at the standard input, i.e.the console
//On the first and the second lines you will find the dimensions of the field R and C
//On the third line you will find the number N, the number of moves
//On the fourth line you will find the CODEs, decimal numbers that represents the positions from the path of the pawn.They will be separated by a single space.The position is encoded as follows:
//•	A coefficient is calculated, COEFF = MAX(R, C)
//•	ROW = CODE / COEF
//•	COL = CODE % COEF
//The input will be valid, in the specified format, within the constraints given below.There is no need to check the input data explicitly.
//Output
//Print the sum of cells contained in the path of pawn
//Constraints
//•	R will always be between 1 and 100
//•	C will always be between 1 and 75
//•	N will always be between 1 and 1000
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.
//Example
//Input            Output              Explanation
//5                 1107              In the example
//6
//4
//14 27 1 5		



namespace _12.BitShiftMatrix
{

   using System;
   using System.Linq;
   using System.Numerics;


   //1. Read Input
   //2. Declear a Field/Matrix with R and C
   //3. For every Move 
       //3.1. Calculate move coordinates
      //3.2. Go to Column and collect everythin on the Way and mark it as already collected
      //3.3. Go to Row and collect everythin on the Way and mark it as already collected
   //4. Print the Result/Sum



   class BitShiftMatrix
   {
      static void Main(string[] args)
      {
         var rowsCount = int.Parse(Console.ReadLine());
         var colsCount = int.Parse(Console.ReadLine());


         var n = Console.ReadLine();

         var collected = new bool[rowsCount, colsCount]; //Matrix

         var moves = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();


         //The Coordinates of the 1.Position - the lowest left Corner
         var row = rowsCount - 1;
         var col = 0;
         BigInteger currentCellValue = 1; //given in the Task

         var coeff = Math.Max(rowsCount, colsCount);

         BigInteger sum = 0;

         foreach (var move in moves)
         {

            var nextRow = move / coeff;
            var nextCol = move % coeff;

            
            //The Logic got the Column

            var deltaCol = col > nextCol ? -1 : 1; //if the column is bigger that the targeted column, go left (-1), otherwise go                                          right (1) 
            while (col != nextCol) //move until the col is diffrent than the nextCol => the columns became the same
            {
               if (!collected[row, col]) //if it's not summed up, sum ot up
               {
                  sum += currentCellValue;
                  collected[row, col] = true; // note that it is summed up
               }

               if (deltaCol == 1)
               {
                  currentCellValue *= 2;
               }
               else
               {
                  currentCellValue /= 2;

               }

               col += deltaCol; // Update moving to the next one
            }



            //The Logic for the Row

            var deltaRow = row > nextRow ? -1 : 1;

            while (row != nextRow)
            {
               if (!collected[row, col])
               {
                  sum += currentCellValue;
                  collected[row, col] = true;
               }

               if (deltaRow == 1)
               {
                  currentCellValue /= 2;
               }
               else
               {
                  currentCellValue *= 2;
               }

               row += deltaRow;

            }
         }

         sum += currentCellValue;

         Console.WriteLine(sum);

      }
   }
}
