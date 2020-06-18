//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/143/CSharp-Part-2-2013-2014-24-Jan-2014-Evening


//You are given a matrix of digits.The matrix contains some patterns that form digits.Your task is to find these digits and calculate their sum:
//The digit patterns are as follows:
//Each digit patterns is formed by the same digit:
//•	The one-digit pattern is formed from cells with the digit one
//•	The nine-digit pattern is formed from cells with the digit nine
//•	Etc…
//The size of the patterns is constant and always has the given form.

//Example:
//The digit patterns are marked in green, red and blue
//Four digit patterns are found – twice one-digit, one seven-digit and one four-digit pattern.
//The sum is 1 + 1 + 4 + 7 = 13

//Input
//On the first line of the console you will find the number N – the number of rows and columns of the matrix
//On the next N lines you will find exactly N digits, separated by a space. These are the digits of the matrix.
//The input data will always be valid and in the described format.There is no need to check it explicitly.
//Output
//The output data consists of a single line.It should contain the sum of all the digit patterns in the matrix
//Constraints
//•	N will always be greater or equal to 5 and less or equal to 1250
//•	The values in the matrix will always be digits
//•	Allowed working time for your program: 0.3 seconds.
//•	Allowed memory: 32 MB.
//Examples
//Input              Output               Explanation
//5
//1 1 1 1 1
//1 1 1 1 1
//1 1 1 1 1
//1 1 1 1 1
//1 1 1 1 1	            3	               The one-patern is found three times.
//                                        The sum is 1+1+1 = 3


//Input              Output                Explanation
//7
//9 9 9 2 2 2
//9 9 9 2 2 2
//9 9 9 2 2 2
//9 9 9 2 2 2
//9 9 9 2 2 2
//9 9 9 2 2 2	         22	                  The nine-pattern is found twice and the two-pattern is also found twice.
//                                           The sum is 9 + 9 + 2 + 2 = 22


//Input                Output                 Explanation
//8
//3 2 1 1 2 3 0 1
//2 1 1 9 7 6 4 0
//1 4 1 7 7 7 5 1
//2 4 1 4 2 7 1 1
//3 4 1 4 7 1 3 1
//0 4 4 4 7 4 5 1
//5 8 2 4 7 3 2 1
//1 2 7 4 9 2 1 8	         13	                  This is explained in the example above

namespace _13.Digits
{
   using System;
   using System.Collections.Generic;

   class Digits
   {

      static int[,] digits; // Global for the whole Class 

      static void Main()
      {
         int n = int.Parse(Console.ReadLine());


         var patterns = InitializeListOfPatterns();

         digits = new int[n, n];

         for (int row = 0; row < n; row++)
         {
            string[] currentLine = Console.ReadLine().Split(' ');
            for (int col = 0; col < currentLine.Length; col++)
            {
               digits[row, col] = int.Parse(currentLine[col]);
            }
         }


         int sum = 0;

         for (int row = 0; row <= n - 5; row++) // -5, so it wouldn't get out of the matrix
         {
            for (int col = 0; col <= n - 3; col++) // -3, so it wouldn't get out of the matrix
            {
               if (digits[row + 2, col] == 1)
               {
                  if (CheckPattern(patterns[1], 1, row, col))
                  {
                     sum += 1;
                     continue;
                  }
                 
               }

               if (digits[row + 1, col] == 2)
               {
                  if (CheckPattern(patterns[2], 2, row, col))
                  {
                     sum += 2;
                     continue;
                  }

               }

               int currentDigit = digits[row, col];

               if (CheckPattern(patterns[currentDigit], currentDigit, row, col))
               {
                  sum += currentDigit;
               }
            }

         }

      }


      static List<bool[,]> InitializeListOfPatterns()
      {
         var list = new List<bool[,]>();

         list.Add(new bool[,]
         {

         });


         //1
         list.Add(new bool[,]
         {
            { false, false, true},
            { false, true, true},
            { true, false, true},
            { false, false, true},
            { false, false, true}
         });


         //2
         list.Add(new bool[,]
         {
            { false, true, false},
            { true, false, true},
            { false, false, true},
            { false, true, false},
            { true, true, true}
         });

         //3
         list.Add(new bool[,]
         {
            { true, true, true},
            { false, false, true},
            { false, true, true},
            { false, false, true},
            { true, true, true}
         });

         //4
         list.Add(new bool[,]
         {
            { true, false, true},
            { true, false, true},
            { true, true, true},
            { false, false, true},
            { false, false, true}
         });

         //5
         list.Add(new bool[,]
         {
            { true, true, true},
            { true, false, false},
            { true, true, true},
            { false, false, true},
            { true, true, true}
         });

         //6
         list.Add(new bool[,]
         {
            { true, true, true},
            { true, false, false},
            { true, true, true},
            { true, false, true},
            { true, true, true}
         });

         //7
         list.Add(new bool[,]
         {
            { true, true, true},
            { false, false, true},
            { false, true, false},
            { false, true, false},
            { false, true, false}
         });

         //8
         list.Add(new bool[,]
         {
            { true, true, true},
            { true, false, true},
            { false, true, false},
            { true, false, true},
            { true, true, true}
         });

         //9
         list.Add(new bool[,]
         {
            { true, true, true},
            { true, false, true},
            { false, true, true},
            { false, false, true},
            { true, true, true}
         });


         return list;
      }


      static bool CheckPattern(bool[,] pattern, int digit, int row, int col)
      {
         bool result = true;

         for (int i = 0; i < pattern.GetLength(0); i++)
         {
            for (int j = 0; j < pattern.GetLength(1); j++)
            {
               if (pattern[i, j])
               {
                  if (digits[row + i, col + j] != digit)
                  {
                     return false;
                  }
               }
            }
         }
         return true;
      }
   }
}
