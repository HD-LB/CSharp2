//http://bgcoder.com/Contests/142/CSharp-Part-2-2013-2014-22-Jan-2014-Evening

//http://my.telerikacademy.com/Courses/Courses/Details/331

//http://my.telerikacademy.com/Courses/LectureResources/Video/8376/%d0%97%d0%b0%d0%b4%d0%b0%d1%87%d0%b0-Patterns-%d0%9a%d1%80%d0%b8%d1%81%d1%82%d0%b8%d1%8f%d0%bd

//You are given a matrix of numbers.By given the pattern below, find the pattern with maximal sum:
//The pattern consists of neighbor cells in the matrix.The numbers in the cells must be consecutive, i.e.the following rules must be always valid:
//A = B - 1, B = C – 1, C = D – 1, D = F – 1, F = E – 1, E = G - 1
//The size of the pattern is constant and always has the given form.
//Example:
//The patterns here are marks with green, blue and yellow colors:
//•	The green pattern has a sum of its numbers 35
//•	The blue pattern has a sum of its numbers 56
//•	The yellow pattern has a sum of its numbers -14
//The winning pattern is the blue with maximal sum of 56



//Input
//On the first line of the console you will find the number N – the number of rows and columns of the matrix
//On the next N lines you will find exactly N numbers, separated by a space. This are the numbers of the matrix.
//The input data will always be valid and in the described format.There is no need to check it explicitly.
//Output
//The output data consists of a single line.It should start with either “YES” or “NO”:
//•	If at least one pattern is found in the matrix – print “YES { sum}”, where sum is the sum of the numbers in the maximal pattern
//•	If no patterns are to be found in the matrix – print “NO {sum}”, where sum is the sum of the numbers, that are on the main diagonal of the matrix
//Constraints
//•	N will always be greater or equal to 5 and less or equal to 1000
//•	The numbers in the matrix will always be between -2147483648 and 2147483647
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.
//Examples:


//Input        Output       Explanation
//5            YES 42       The found patterns are:
//                          The last one has the biggest sum, equal to 3+4+5+6+7+8+9 = 42
//1 2 3 4 5
//2 3 4 5 6
//3 4 5 6 7
//4 5 6 7 8
//5 6 7 8 9  		

//Input              Output   Explanation
//7                  NO 28     There are no patterns in this matrix
//                             The sum of the main diagonal is printed:
//                             1+6+3+4+5+2+7 = 28
//1 2 3 4 5 6 7      
//7 6 5 4 3 2 1
//1 2 3 4 5 6 7
//7 6 5 4 3 2 1
//1 2 3 4 5 6 7
//7 6 5 4 3 2 1
//1 2 3 4 5 6 7	 	

//Input                 Output    Explanation
//8                      YES 56   This is explained in the example above

//2 3 4 5 5 4 100 5
//5 4 5 1 2 4 3 -2
//1 5 6 7 8 6 1 8
//-9999 2 3 8 5 6 7 8
//2 1 4 9 10 11 -4 6
//-5 -4 -3 3 4 5 6 77777
//5 -111 -2 2 1 3 7 4
//6 7 -1 0 1 2 8 9		

namespace _03.Patterns
{
   using System;
  

   class Patterns
   {
      static void Main()
      {
         //Creating the Matrix
         int n = int.Parse(Console.ReadLine());
         int[,] matrix = new int[n, n];
         
         for (int i = 0; i < n; i++)
         {
            string[] line = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
               matrix[i, j] = int.Parse(line[j]);
            }
         }


         //Reading the Matrix
         long maxSum = long.MinValue;
         bool found = false;

         for (int i = 0; i + 2 < n; i++)
         {
            for (int j = 0; j + 4 < n; j++)
            {
               if ((matrix[i, j] + 1 == matrix[i, j + 1])
               && (matrix[i, j] + 2 == matrix[i, j + 2])
               && (matrix[i, j] + 3 == matrix[i + 1, j + 2])
               && (matrix[i, j] + 4 == matrix[i + 2, j + 2])
               && (matrix[i, j] + 5 == matrix[i + 2, j + 3])
               && (matrix[i, j] + 6 == matrix[i + 2, j + 4]))
               {
                  found = true;
                  long sum = 7L * matrix[i, j] + 21; //0 + 1 + 2 + 3 + 4 + 5 + 6 = 21
                                                   //Pattern is constisted of 7 cells, 7 has to be long
                  if (maxSum < sum)
                  {
                     maxSum = sum;
                  }
               }
            }
         }
         if (!found)
         {
            //Console.WriteLine("NO {0}", );
         }
         else
         {
            Console.WriteLine("YES {0}", maxSum);
         }
         




        
      }
   }
}
