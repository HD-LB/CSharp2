//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/55/CSharp-Part-2-2012-2013-11-Feb-2013

//You are given N number of rows.Each row contains a different number of columns.Each cell in a row contains a negative number or an index of a cell on the next row, i.e.rows[row][column] holds an index of cell in [row+1]. The row after the last row is the first row.If the number of columns on the next row is C, each of the cells on the current row are in the range [-C, C-1] inclusive.
//A path in the rows is the max number of cells that can be passed, starting from any of the cells on the first row, and following the pattern above (i.e.each cell on row R, holds a negative number or an index on row R+1). The path ends when the path reaches an already visited cell in this path, or the number in the cell is negative.
//A special value is the sum of the path + the absolute value of a negative number reached. If a path reaches a visited cell, this path cannot get a special value.
//Your task is to find the biggest special value using the given rows.
//Input
//The input data should be read from the console.
//On the first line you will be given the number N.
//On the next N lines you will be given the numbers in each row, separated with ", " (comma and space).
//Output
//The output data should be printed on the console.
//The output should contain only the maximal special number.
//Constraints
//•	The rows will be between 1 and 1000 inclusive.
//•	The cells on each row will be between 1 and 1000 inclusive.
//•	Allowed working time for your program: 0.5 seconds.Allowed memory: 16 MB.
//Examples
//Input example                            Output example
//4
//-1, 0, -3, -2, 0, -2
//-1, 3, 1, 0, 2, 0
//-9, 1, 1, -7
//1, -5, -3, -1, 3, -2, 2, 1, 1	             4 (starting from column 2)
//                                            //special value = 1 + |-3|


//6
//5, -4, 8, -5, 0
//1, -2, -1, 1, 0, -1, -1, -2, 1
//3, -5
//4, -9, -4, 4, 0, 7
//1, -2, -8, 4, -8, 7, -5, -4, -4
//4, -1, 0, -3, 2, 4, -4, 1	                8 (starting from column 2)
//                                            // special value = 3 + |-5| 


//2
//0, -3, 0, 3
//-3, 3, 0, 2, 0	                            7 (starting from column 3)
//                                            //special value = 4 + |-3|
//                                            //the path is [0][3] -> [1,3] -> [0,2] -> [1,0]


//2
//0, -3, 0, 3
//0, 3, 0, 2, 0	                            4 (starting from column 1)
//                                           //the only path is from column 1
//                                           //the other paths don't reach //negative number,



namespace _05.SpecialValue
{
   using System;

   class SpecialValue
   {
      static int[][] ReadDate(int[][] field)
      {
         for (int i = 0; i < field.GetLength(0); i++)
         {
            string[] currentLine = Console.ReadLine()
                                          .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            field[i] = new int[currentLine.Length];

            for (int l = 0; l < currentLine.Length; l++)
            {
               field[i][l] = int.Parse(currentLine[i]);
            }
                       

         }
         return field;

      }

      static long FinfCurrentSpecialValue(int[][] field, int column, bool[][] used)
      {
         long result = 0;
         int currentRow = 0;

         while (true)
         {
            result++;

            if (used[currentRow][column])
            {
               return long.MinValue;
            }

            if (field[currentRow][column] < 0)
            {
               result -= field[currentRow][column];
               return result;
            }

            int nextColumn = field[currentRow][column];
            used[currentRow][column] = true;
            column = nextColumn;


            currentRow++;

            if (currentRow == field.GetLength(0))
            {
               currentRow = 0;
            }
         }



         return result;


      }


      static void Main()
      {
         int N = int.Parse(Console.ReadLine());

         int[][] field = new int[N][]; //N rows, no definite columns


         ReadDate(field);

         bool[][] used = new bool[N][];

         for (int i = 0; i < N; i++)
         {
            used[i] = new bool[field[i].Length];
         }

         long max = long.MinValue;

         for (int i = 0; i < field[0].Length; i++)
         {
            long specialValue = FinfCurrentSpecialValue(field, i, used);

            if (max < specialValue)
            {
               max = specialValue;
            }
         }

         Console.WriteLine(max);


      }
   }
}
